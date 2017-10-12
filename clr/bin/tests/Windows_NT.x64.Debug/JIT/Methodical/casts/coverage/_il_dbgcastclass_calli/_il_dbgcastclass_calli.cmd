@ECHO OFF
setlocal ENABLEDELAYEDEXPANSION
set "lockFolder=%~dp0\lock"
pushd %~dp0


REM Parse Command Line
:NextArg

IF /I '%1' == '-?'     GOTO :USAGE
IF /I '%1' == '/?'     GOTO :USAGE
IF /I '%1' == '-h'     GOTO :USAGE
IF /I '%1' == '/h'     GOTO :USAGE

set cond=0
IF /I [%1] == [-debug] set cond=1
IF /I [%1] == [/debug] set cond=1
IF %cond% EQU 1 (

    IF EXIST "%2" (
        set _DebuggerFullPath=%2
    ) ELSE (
        ECHO The Debugger FullPath "%2" doesn't exist
        GOTO :USAGE
    )
        
shift
IF /I [true] == [true] shift
goto NextArg
)
set cond=0
IF /I [%1] == [-env] set cond=1
IF /I [%1] == [/env] set cond=1
IF %cond% EQU 1 (

    IF EXIST "%2" (
        set __TestEnv=%2
    ) ELSE (
        ECHO The environment script "%2" does not exist
        GOTO :USAGE
    )
        
shift
IF /I [true] == [true] shift
goto NextArg
)
set cond=0
IF /I [%1] == [-coreroot] set cond=1
IF /I [%1] == [/coreroot] set cond=1
IF %cond% EQU 1 (

    set CORE_ROOT=%2
        
shift
IF /I [true] == [true] shift
goto NextArg
)

if NOT "%1" == "" (
set CLRTestExecutionArguments=%*
goto :ArgsDone
)

goto ArgsDone

:USAGE
ECHO.Usage
ECHO %0  [-debug debuggerFullPath] [-env envScriptFullPath] [-coreroot CoreRootFullPath]
ECHO.
ECHO                         - OPTIONS -
ECHO -debug debuggerFullPath
ECHO      Run testcases under debugger.
ECHO -env envScriptFullPath
ECHO      Run the specified script to set environment variables before running the test.
ECHO -coreroot CoreRootFullPath
ECHO      Set CORE_ROOT to the specified value before running the test.
popd
Exit /b 1

:ArgsDone

      

if not defined CLRTestExpectedExitCode (set CLRTestExpectedExitCode=100)
ECHO BEGIN EXECUTION
      

REM The __TestEnv variable may be used to specify something to run before the test.
IF NOT "%__TestEnv%"=="" call %__TestEnv%

REM Environment Variables


      




REM JitDisasm Script
if defined RunningJitDisasm (
  echo %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\..\dasm\JIT\Methodical\casts\coverage\_il_dbgcastclass_calli _il_dbgcastclass_calli.exe
  %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\..\dasm\JIT\Methodical\casts\coverage\_il_dbgcastclass_calli _il_dbgcastclass_calli.exe
  IF NOT "!ERRORLEVEL!"=="0" (
    ECHO EXECUTION OF JIT-DASM - FAILED !ERRORLEVEL!
    Exit /b 1
  )
  Exit /b 0
)
    


REM IlasmRoundTrip Script

REM Disable Ilasm round-tripping for Linker tests.
REM Todo: Ilasm round-trip on linked binaries.
IF NOT DEFINED DoLink (
  IF DEFINED RunningIlasmRoundTrip (
    echo %CORE_ROOT%\ildasm.exe /raweh /out=_il_dbgcastclass_calli.dasm.il _il_dbgcastclass_calli.exe
    %CORE_ROOT%\ildasm.exe /raweh /out=_il_dbgcastclass_calli.dasm.il _il_dbgcastclass_calli.exe
    IF NOT "!ERRORLEVEL!"=="0" (
      ECHO EXECUTION OF ILDASM - FAILED !ERRORLEVEL!
      Exit /b 1
    )
    ECHO %CORE_ROOT%\ilasm.exe /output=_il_dbgcastclass_calli.asm.exe -QUIET -NOLOGO -DEBUG _il_dbgcastclass_calli.dasm.il
    %CORE_ROOT%\ilasm.exe /output=_il_dbgcastclass_calli.asm.exe -QUIET -NOLOGO -DEBUG _il_dbgcastclass_calli.dasm.il
    IF NOT "!ERRORLEVEL!"=="0" (
      ECHO EXECUTION OF ILASM - FAILED !ERRORLEVEL!
      Exit /b 1
    )
  )
)
        

REM Precommands
REM Long GC script
if defined RunningLongGCTests (
  echo Skipping execution because this is not a long-running GC test.
  Exit /b 0
)
REM GCSimulator script
if defined RunningGCSimulatorTests (
  echo Skipping execution because this is not a GCSimulator test.
  Exit /b 0
)
REM CrossGen Script
if defined RunCrossGen ( 
    set COMPlus_ZapRequire=2
    set COMPlus_ZapRequireList=_il_dbgcastclass_calli
    if not exist "_il_dbgcastclass_calli.org" (
        call :TakeLock
        set CrossGenStatus=0
        if not exist "_il_dbgcastclass_calli.org" (
            mkdir IL
            copy _il_dbgcastclass_calli.exe IL\_il_dbgcastclass_calli.exe 
            ren _il_dbgcastclass_calli.exe _il_dbgcastclass_calli.org
            echo "%_DebuggerFullPath% %CORE_ROOT%\crossgen.exe" /Platform_Assemblies_Paths %CORE_ROOT%;%cd%\IL;%cd% /in _il_dbgcastclass_calli.org /out _il_dbgcastclass_calli.exe
            %_DebuggerFullPath% "%CORE_ROOT%\crossgen.exe" /Platform_Assemblies_Paths %CORE_ROOT%;%cd%\IL;%cd% /in _il_dbgcastclass_calli.org /out _il_dbgcastclass_calli.exe
            set CrossGenStatus=!ERRORLEVEL!
        )
        call :ReleaseLock
        IF NOT !CrossGenStatus!==0 (
            ECHO Crossgen failed with exitcode - !CrossGenStatus!
            Exit /b 1
        )
    )
) 
        
REM Launch

set ExePath=_il_dbgcastclass_calli.exe

REM Linker commands

set LinkBin=__Link
set Assemblies=-a System.Private.CoreLib

IF defined DoLink ( 
    IF NOT EXIST !ILLINK! (
      ECHO ILLink executable [%ILLINK%] Invalid
      popd
      Exit /b 1
    )
    
    REM Clean up old Linked binaries, if any
    IF EXIST %LinkBin% rmdir /s /q %LinkBin%
    
    REM Remove Native images, since the goal is to run from Linked binaries
    del /q /f *.ni.* 2> nul

    REM Use hints for reflection roots, if provided in _il_dbgcastclass_calli.reflect.xml
    IF EXIST _il_dbgcastclass_calli.reflect.xml set ReflectionRoots=-x _il_dbgcastclass_calli.reflect.xml

    REM Include all .exe files in this directory as entry points (some tests had multiple .exe file modules)
    FOR /F "delims=" %%E IN ('dir /b *.exe *.dll') DO SET Assemblies=!Assemblies! -a %%~nE

    REM Run dotnet-linker
    REM Run the Linker such that all assemblies except System.Private.Corlib.dll are linked
    REM Debug symbol generation needs some fixes, and is currently omitted.
    REM Once this is fixed, add -b true option.
    ECHO %ILLINK% -out %LinkBin% -d %CORE_ROOT% -c link -l none -t !Assemblies! !ReflectionRoots!
    %ILLINK% -out %LinkBin% -d %CORE_ROOT% -c link -l none -t !Assemblies! !ReflectionRoots!
    IF NOT "!ERRORLEVEL!"=="0" (
      ECHO ILLINK FAILED !ERRORLEVEL!
      IF NOT defined KeepLinkedBinaries (
          IF EXIST %LinkBin% rmdir /s /q %LinkBin%
      )
      popd
      Exit /b 1
    )

    REM Copy CORECLR native binaries to %LinkBin%, so that we can run the test based on that directory
    copy %CORE_ROOT%\clrjit.dll %LinkBin% > nul 2> nul
    copy %CORE_ROOT%\coreclr.dll %LinkBin% > nul 2> nul
    copy %CORE_ROOT%\mscorrc.dll %LinkBin% > nul 2> nul
    copy %CORE_ROOT%\CoreRun.exe %LinkBin% > nul 2> nul

    REM Copy some files that may be arguments
    copy *.txt %LinkBin% > nul 2> nul

    set ExePath=%LinkBin%\_il_dbgcastclass_calli.exe
    set CORE_ROOT=%~dp0%LinkBin%
)


IF NOT "%CLRCustomTestLauncher%"=="" (
  set LAUNCHER=call %CLRCustomTestLauncher% %~dp0
) ELSE (
  set LAUNCHER=%_DebuggerFullPath% "%CORE_ROOT%\corerun.exe"
)

IF NOT DEFINED DoLink (
  if defined RunningIlasmRoundTrip (
    ECHO %LAUNCHER% _il_dbgcastclass_calli.asm.exe %CLRTestExecutionArguments% %Host_Args%
    %LAUNCHER% _il_dbgcastclass_calli.asm.exe %CLRTestExecutionArguments% %Host_Args%

    IF NOT "!ERRORLEVEL!"=="%CLRTestExpectedExitCode%" (
      ECHO END EXECUTION OF IL{D}ASM BINARY - FAILED !ERRORLEVEL! vs %CLRTestExpectedExitCode%
      ECHO FAILED
      Exit /b 1
    )
  )
)

      

if defined RunCrossGen (
  call :TakeLock
)
ECHO %LAUNCHER% %ExePath% %CLRTestExecutionArguments%
%LAUNCHER% %ExePath% %CLRTestExecutionArguments%
set CLRTestExitCode=!ERRORLEVEL!
if defined RunCrossGen (
  call :ReleaseLock
)

REM Clean up the LinkBin directories after test execution.
REM Otherwise, RunTests may run out of disk space.

if defined DoLink (
    if not defined KeepLinkedBinaries (
        IF EXIST %LinkBin% rmdir /s /q %LinkBin%
    )
)              

      
REM PostCommands


ECHO Expected: %CLRTestExpectedExitCode%
ECHO Actual: %CLRTestExitCode%
IF NOT "%CLRTestExitCode%"=="%CLRTestExpectedExitCode%" (
  ECHO END EXECUTION - FAILED
  ECHO FAILED
  popd
  Exit /b 1
) ELSE (
  ECHO END EXECUTION - PASSED
  ECHO PASSED
  popd
  Exit /b 0
)

:TakeLock
md %lockFolder%
IF NOT "!ERRORLEVEL!"=="0" (
timeout /t 10 /nobreak
goto :TakeLock
)
Exit /b 2


:ReleaseLock
if exist %lockFolder% rd /s /q %lockFolder%
Exit /b 0
