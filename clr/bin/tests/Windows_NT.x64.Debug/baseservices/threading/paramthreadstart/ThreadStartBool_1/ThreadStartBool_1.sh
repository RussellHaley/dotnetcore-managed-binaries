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

if [ -z ${CLRTestExecutionArguments+x} ]; then export CLRTestExecutionArguments='true'; fi
      

if [ -z ${CLRTestExpectedExitCode+x} ]; then export CLRTestExpectedExitCode=100; fi
echo BEGIN EXECUTION

# JitDisasm Script
if [ ! -z $RunningJitDisasm ]
then
    echo $CORE_ROOT/corerun "$CORE_ROOT/jit-dasm.dll" --crossgen $CORE_ROOT/crossgen --platform $CORE_ROOT --output ../../../../dasm/baseservices/threading/paramthreadstart/ThreadStartBool_1 ../ThreadStartBool/ThreadStartBool.sh
    "$CORE_ROOT/corerun" "$CORE_ROOT/jit-dasm.dll" --crossgen $CORE_ROOT/crossgen --platform $CORE_ROOT --output ../../../../dasm/baseservices/threading/paramthreadstart/ThreadStartBool_1 ../ThreadStartBool/ThreadStartBool.sh
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
    echo "$CORE_ROOT/ildasm" -raweh -out=ThreadStartBool_1.dasm.il ../ThreadStartBool/ThreadStartBool.sh
    "$CORE_ROOT/ildasm" -raweh -out=ThreadStartBool_1.dasm.il ../ThreadStartBool/ThreadStartBool.sh
    ERRORLEVEL=$?
    if [ $ERRORLEVEL -ne 0 ]
    then
      echo EXECUTION OF ILDASM - FAILED $ERRORLEVEL
      exit 1
    fi

    echo "$CORE_ROOT/ilasm" -output=ThreadStartBool_1.asm.exe  ThreadStartBool_1.dasm.il
    "$CORE_ROOT/ilasm" -output=ThreadStartBool_1.asm.exe  ThreadStartBool_1.dasm.il
    ERRORLEVEL=$?
    if [ $ERRORLEVEL -ne 0 ]
    then
      echo EXECUTION OF ILASM - FAILED $ERRORLEVEL
      exit 1
    fi
fi
        
# PreCommands
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
# Launch


if [ -z "$DoLink" -a ! -z "$RunningIlasmRoundTrip" ]
then
  echo "$CORE_ROOT/corerun" ThreadStartBool_1.asm.exe $CLRTestExecutionArguments
  "$CORE_ROOT/corerun" ThreadStartBool_1.asm.exe $CLRTestExecutionArguments
  if [  $? -ne $CLRTestExpectedExitCode ]
  then
    echo END EXECUTION OF IL{D}ASM BINARY - FAILED $? vs $CLRTestExpectedExitCode
    echo FAILED
    exit 1
  fi
fi
      
echo export CDPATH="$(dirname "$0")"
export CDPATH="$(dirname "$0")"
echo /bin/sh -c  ../ThreadStartBool/ThreadStartBool.sh 
/bin/sh -c ../ThreadStartBool/ThreadStartBool.sh
CLRTestExitCode=$?
CLRTestExpectedExitCode=0
      
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
