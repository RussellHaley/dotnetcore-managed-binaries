#!/usr/bin/env bash
TakeLock()
{
    echo "in takeLock"
    if mkdir $LockFile; then
        return 2
    else
        sleep 10
        TakeLock
    fi
    echo "exiting takelock"
}

ReleaseLock()
{
    echo "in ReleaseLock"
    if [ -d "$LockFile" ]; then
        rm -rf "$LockFile"
        return 3
    fi
}
cd "$(dirname "$0")"
LockFile="lock"


# The __TestEnv variable may be used to specify a script to source before the test.
if [ -n "$__TestEnv" ]; then
    source $__TestEnv
fi


        
      


usage()
{
    echo "Usage: $0   [-debug debuggerFullPath] [-env envScriptFullPath] [-coreroot CoreRootFullPath]"
    echo 
    echo "Arguments:"
    echo "-debug=debuggerFullPath"
    echo      "Run testcases under debugger."
    echo "-coreroot=coreRootFullPath"
    echo      "Set CORE_ROOT to the specified value before running the test."
    echo "-?,-h,--help    show this message"
    exit 1
}

# Parse Command Line

for i in "$@"
    do
        case $i in
        -?|-h|--help)
        usage
        ;;
        -debug=*|/debug=*)
        export _DebuggerFullPath="${i#*=}"
        if [ ! -f "$_DebuggerFullPath" ]
        then
            echo "The Debugger FullPath \"${_DebuggerFullPath}\" does not exist"
            usage
        fi
        ;;
-coreroot=*|/coreroot=*)
        CORE_ROOT="${i#*=}"
        ;;
        *)
        CLRTestExecutionArguments="$CLRTestExecutionArguments $i"
    esac
done


      

if [ -z ${CLRTestExpectedExitCode+x} ]; then export CLRTestExpectedExitCode=100; fi
echo BEGIN EXECUTION

# JitDisasm Script
if [ ! -z $RunningJitDisasm ]
then
    echo $CORE_ROOT/corerun "$CORE_ROOT/jit-dasm.dll" --crossgen $CORE_ROOT/crossgen --platform $CORE_ROOT --output ../../../dasm/JIT/SIMD/VectorMul_r VectorMul_r.exe
    "$CORE_ROOT/corerun" "$CORE_ROOT/jit-dasm.dll" --crossgen $CORE_ROOT/crossgen --platform $CORE_ROOT --output ../../../dasm/JIT/SIMD/VectorMul_r VectorMul_r.exe
    _jdExitCode=$?
    if [ $_jdExitCode -ne 0 ]
    then
        echo EXECUTION OF JIT-DASM - FAILED $_jdExitCode
        exit 1
    fi
fi


# IlasmRoundTrip Script

# Disable Ilasm round-tripping for Linker tests.
# Todo: Ilasm round-trip on linked binaries.

if [ -z "$DoLink" -a ! -z "$RunningIlasmRoundTrip" ]
then
    echo "$CORE_ROOT/ildasm" -raweh -out=VectorMul_r.dasm.il VectorMul_r.exe
    "$CORE_ROOT/ildasm" -raweh -out=VectorMul_r.dasm.il VectorMul_r.exe
    ERRORLEVEL=$?
    if [ $ERRORLEVEL -ne 0 ]
    then
      echo EXECUTION OF ILDASM - FAILED $ERRORLEVEL
      exit 1
    fi

    echo "$CORE_ROOT/ilasm" -output=VectorMul_r.asm.exe  VectorMul_r.dasm.il
    "$CORE_ROOT/ilasm" -output=VectorMul_r.asm.exe  VectorMul_r.dasm.il
    ERRORLEVEL=$?
    if [ $ERRORLEVEL -ne 0 ]
    then
      echo EXECUTION OF ILASM - FAILED $ERRORLEVEL
      exit 1
    fi
fi
        
# PreCommands


export COMPlus_JitFuncInfoLogFile=SIMD.log
rm -f SIMD.log
# Long GC script
if [ ! -z $RunningLongGCTests ]
then
    echo "Skipping execution because this is not a long-running GC test"
    exit 2
fi
# GCSimulator script
if [ ! -z $RunningGCSimulatorTests ]
then
    echo "Skipping execution because this is not a GCSimulator test"
    exit 2
fi
# CrossGen Script
if [ ! -z ${RunCrossGen+x} ]; then
    export COMPlus_ZapRequire=2
    export COMPlus_ZapRequireList=VectorMul_r
    if [ ! -f VectorMul_r.org ]; then
        TakeLock
        if [ ! -f VectorMul_r.org ]; then
          mkdir IL
          cp VectorMul_r.exe IL/VectorMul_r.exe
          mv VectorMul_r.exe VectorMul_r.org
          echo $_DebuggerFullPath "$CORE_ROOT/crossgen" /Platform_Assemblies_Paths $CORE_ROOT:$PWD/IL:$PWD /in VectorMul_r.org /out VectorMul_r.exe
          $_DebuggerFullPath "$CORE_ROOT/crossgen" /Platform_Assemblies_Paths $CORE_ROOT:$PWD/IL:$PWD /in VectorMul_r.org /out VectorMul_r.exe
          __cgExitCode=$?
          if [ $__cgExitCode -ne 0 ]
          then
            echo Crossgen failed with exitcode: $__cgExitCode
            ReleaseLock
            exit 1
          fi
        fi 
        ReleaseLock       
    fi        
fi        
        
# Launch

ExePath=VectorMul_r.exe

# Linker commands

LinkBin=__Link
Assemblies="-a System.Private.CoreLib"
ReflectionRoots=

shopt -s nullglob

if [ ! -z "$DoLink" ]
then
  if [ ! -x "$ILLINK" ]
then
    echo "Illink executable [$ILLINK] Invalid"
    exit 1
  fi
  
  # Clean up old Linked binaries, if any
  rm -rf $LinkBin
    
  # Remove Native images, since the goal is to run from Linked binaries
  rm -f *.ni.*

  # Use hints for reflection roots, if provided in VectorMul_r.reflect.xml
  if [ -f VectorMul_r.reflect.xml ]
then
    ReflectionRoots="-x VectorMul_r.reflect.xml"
  fi

  # Include all .exe files in this directory as entry points (some tests had multiple .exe file modules)
  for bin in *.exe *.dll
do 
    Assemblies="$Assemblies -a ${bin%.*}"
  done

  # Run dotnet-linker
  # Run the Linker such that all assemblies except System.Private.Corlib.dll are linked
  # Debug symbol generation needs some fixes, and is currently omitted.
  # Once this is fixed, add -b true option.
  echo "$ILLINK -out $LinkBin -d $CORE_ROOT -c link -l none -t $Assemblies $ReflectionRoots"
  $ILLINK -out $LinkBin -d $CORE_ROOT -c link -l none -t $Assemblies $ReflectionRoots
  ERRORLEVEL=$?
  if [  $ERRORLEVEL -ne 0 ]
  then
    echo ILLINK FAILED $ERRORLEVEL
    if [ -z "$KeepLinkedBinaries" ]
then
      rm -rf $LinkBin
    fi
    exit 1
  fi
  
  # Copy CORECLR native binaries to $LinkBin, 
  # so that we can run the test based on that directory
  cp $CORE_ROOT/*.so $LinkBin/
  cp $CORE_ROOT/corerun $LinkBin/

  # Copy some files that may be arguments
  for f in *.txt
do
    [ -e "$f" ] && cp $f $LinkBin
  done

  ExePath=$LinkBin/VectorMul_r.exe
  export CORE_ROOT=$PWD/$LinkBin
fi


if [ -z "$DoLink" -a ! -z "$RunningIlasmRoundTrip" ]
then
  echo "$CORE_ROOT/corerun" VectorMul_r.asm.exe $CLRTestExecutionArguments
  "$CORE_ROOT/corerun" VectorMul_r.asm.exe $CLRTestExecutionArguments
  if [  $? -ne $CLRTestExpectedExitCode ]
  then
    echo END EXECUTION OF IL{D}ASM BINARY - FAILED $? vs $CLRTestExpectedExitCode
    echo FAILED
    exit 1
  fi
fi
      
if [ ! -z ${RunCrossGen+x} ]; then
  TakeLock
fi
echo $_DebuggerFullPath "$CORE_ROOT/corerun" $ExePath $CLRTestExecutionArguments 
$_DebuggerFullPath "$CORE_ROOT/corerun" $ExePath $CLRTestExecutionArguments 
CLRTestExitCode=$?
if [ ! -z ${RunCrossGen+x} ]; then
  ReleaseLock
fi

# Clean up the LinkBin directories after test execution.
# Otherwise, RunTests may run out of disk space.

if [ ! -z "$DoLink" ]
then
  if [ -z "$KeepLinkedBinaries" ]
then
    rm -rf $LinkBin
  fi
fi

      
# PostCommands


echo Expected: $CLRTestExpectedExitCode
echo Actual: $CLRTestExitCode
if [ $CLRTestExitCode -ne $CLRTestExpectedExitCode ]
then
  echo END EXECUTION - FAILED
  exit 1
else
  echo END EXECUTION - PASSED
  exit 0
fi
