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

if not defined CLRTestExecutionArguments (set CLRTestExecutionArguments=true )
      
      

if not defined CLRTestExpectedExitCode (set CLRTestExpectedExitCode=100)
ECHO BEGIN EXECUTION
      

REM The __TestEnv variable may be used to specify something to run before the test.
IF NOT "%__TestEnv%"=="" call %__TestEnv%

REM Environment Variables


      




REM JitDisasm Script
if defined RunningJitDisasm (
  echo %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\dasm\baseservices\threading\paramthreadstart\ThreadStartBool_1 ..\ThreadStartBool\ThreadStartBool.cmd
  %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\dasm\baseservices\threading\paramthreadstart\ThreadStartBool_1 ..\ThreadStartBool\ThreadStartBool.cmd
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
    echo %CORE_ROOT%\ildasm.exe /raweh /out=ThreadStartBool_1.dasm.il ..\ThreadStartBool\ThreadStartBool.cmd
    %CORE_ROOT%\ildasm.exe /raweh /out=ThreadStartBool_1.dasm.il ..\ThreadStartBool\ThreadStartBool.cmd
    IF NOT "!ERRORLEVEL!"=="0" (
      ECHO EXECUTION OF ILDASM - FAILED !ERRORLEVEL!
      Exit /b 1
    )
    ECHO %CORE_ROOT%\ilasm.exe /output=ThreadStartBool_1.asm.exe  ThreadStartBool_1.dasm.il
    %CORE_ROOT%\ilasm.exe /output=ThreadStartBool_1.asm.exe  ThreadStartBool_1.dasm.il
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
REM Launch


IF NOT "%CLRCustomTestLauncher%"=="" (
  set LAUNCHER=call %CLRCustomTestLauncher% %~dp0
) ELSE (
  set LAUNCHER=%_DebuggerFullPath% "%CORE_ROOT%\corerun.exe"
)

IF NOT DEFINED DoLink (
  if defined RunningIlasmRoundTrip (
    ECHO %LAUNCHER% ThreadStartBool_1.asm.exe %CLRTestExecutionArguments% %Host_Args%
    %LAUNCHER% ThreadStartBool_1.asm.exe %CLRTestExecutionArguments% %Host_Args%

    IF NOT "!ERRORLEVEL!"=="%CLRTestExpectedExitCode%" (
      ECHO END EXECUTION OF IL{D}ASM BINARY - FAILED !ERRORLEVEL! vs %CLRTestExpectedExitCode%
      ECHO FAILED
      Exit /b 1
    )
  )
)

      
ECHO  cmd /c ..\ThreadStartBool\ThreadStartBool.cmd
cmd /c ..\ThreadStartBool\ThreadStartBool.cmd
set CLRTestExpectedExitCode=0
set CLRTestExitCode=!ERRORLEVEL!
      
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
