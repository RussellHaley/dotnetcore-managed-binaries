using Xunit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using CoreclrTestLib;

namespace JIT_opt
{
        internal class _Global
        {
            internal static bool runningInWindows;
            internal static string reportBase;
            internal static string testBinaryBase;
            internal static string coreRoot;

            static _Global()
            {
                reportBase = System.Environment.GetEnvironmentVariable("XunitTestReportDirBase");
                testBinaryBase = System.IO.Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
                coreRoot = System.IO.Path.GetFullPath(System.Environment.GetEnvironmentVariable("CORE_ROOT"));

                if (String.IsNullOrEmpty(reportBase)) {
                    reportBase = System.IO.Path.Combine(testBinaryBase, "Reports");
                }
                else
                {
                    reportBase = System.IO.Path.GetFullPath(reportBase);
                }

                if (String.IsNullOrEmpty(coreRoot)) {
                    throw new ArgumentException("Environment variable CORE_ROOT is not set");
                }

                string operatingSystem = System.Environment.GetEnvironmentVariable("OS");
                runningInWindows = (operatingSystem != null && operatingSystem.StartsWith("Windows"));
            }
        }


public class _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_
        {
            [Fact]
            public void _AssertionPropagation_ArrBoundUnsigned_ArrBoundUnsigned_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\AssertionPropagation\ArrBoundUnsigned\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ArrBoundUnsigned.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ArrBoundUnsigned.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\AssertionPropagation\ArrBoundUnsigned\ArrBoundUnsigned.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _DumpDisasm_JitMinOpts_InstrCnt1_InstrCnt1_
        {
            [Fact]
            public void _DumpDisasm_JitMinOpts_InstrCnt1_InstrCnt1_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\DumpDisasm\JitMinOpts\InstrCnt1\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"InstrCnt1.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"InstrCnt1.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DumpDisasm\JitMinOpts\InstrCnt1\InstrCnt1.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _ETW_TailCallCases_TailCallCases_
        {
            [Fact]
            public void _ETW_TailCallCases_TailCallCases_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\ETW\TailCallCases\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailCallCases.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailCallCases.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ETW\TailCallCases\TailCallCases.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _FastTailCall_FastTailCallCandidates_FastTailCallCandidates_
        {
            [Fact]
            public void _FastTailCall_FastTailCallCandidates_FastTailCallCandidates_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\FastTailCall\FastTailCallCandidates\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FastTailCallCandidates.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FastTailCallCandidates.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FastTailCall\FastTailCallCandidates\FastTailCallCandidates.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _FastTailCall_FastTailCallInlining_FastTailCallInlining_
        {
            [Fact]
            public void _FastTailCall_FastTailCallInlining_FastTailCallInlining_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\FastTailCall\FastTailCallInlining\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FastTailCallInlining.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FastTailCallInlining.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FastTailCall\FastTailCallInlining\FastTailCallInlining.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _FastTailCall_GitHubIssue12479_GitHubIssue12479_
        {
            [Fact]
            public void _FastTailCall_GitHubIssue12479_GitHubIssue12479_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\FastTailCall\GitHubIssue12479\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"GitHubIssue12479.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"GitHubIssue12479.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FastTailCall\GitHubIssue12479\GitHubIssue12479.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _FastTailCall_StackFixup_StackFixup_
        {
            [Fact]
            public void _FastTailCall_StackFixup_StackFixup_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\FastTailCall\StackFixup\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"StackFixup.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"StackFixup.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FastTailCall\StackFixup\StackFixup.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _FastTailCall_StructPassingSimple_StructPassingSimple_
        {
            [Fact]
            public void _FastTailCall_StructPassingSimple_StructPassingSimple_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\FastTailCall\StructPassingSimple\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"StructPassingSimple.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"StructPassingSimple.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FastTailCall\StructPassingSimple\StructPassingSimple.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _Inline_tests_calli_calli_
        {
            [Fact]
            public void _Inline_tests_calli_calli_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\Inline\tests\calli\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"calli.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"calli.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Inline\tests\calli\calli.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _Inline_tests_InlineThrow_InlineThrow_
        {
            [Fact]
            public void _Inline_tests_InlineThrow_InlineThrow_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\Inline\tests\InlineThrow\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"InlineThrow.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"InlineThrow.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Inline\tests\InlineThrow\InlineThrow.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _Inline_tests_mathfunc_mathfunc_
        {
            [Fact]
            public void _Inline_tests_mathfunc_mathfunc_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\Inline\tests\mathfunc\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mathfunc.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mathfunc.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Inline\tests\mathfunc\mathfunc.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _perf_doublealign_Arrays_Arrays_
        {
            [Fact]
            public void _perf_doublealign_Arrays_Arrays_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\perf\doublealign\Arrays\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Arrays.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Arrays.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perf\doublealign\Arrays\Arrays.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _Tailcall_TailcallVerifyWithPrefix_TailcallVerifyWithPrefix_
        {
            [Fact]
            public void _Tailcall_TailcallVerifyWithPrefix_TailcallVerifyWithPrefix_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\Tailcall\TailcallVerifyWithPrefix\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailcallVerifyWithPrefix.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailcallVerifyWithPrefix.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Tailcall\TailcallVerifyWithPrefix\TailcallVerifyWithPrefix.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _Types_Equality_Equality_
        {
            [Fact]
            public void _Types_Equality_Equality_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\Types\Equality\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Equality.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Equality.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Types\Equality\Equality.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _virtualstubdispatch_bigvtbl_bigvtbl_cs_do_bigvtbl_cs_do_
        {
            [Fact]
            public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_do_bigvtbl_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\virtualstubdispatch\bigvtbl\bigvtbl_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\virtualstubdispatch\bigvtbl\bigvtbl_cs_do\bigvtbl_cs_do.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _virtualstubdispatch_bigvtbl_bigvtbl_cs_ro_bigvtbl_cs_ro_
        {
            [Fact]
            public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_ro_bigvtbl_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\virtualstubdispatch\bigvtbl\bigvtbl_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\virtualstubdispatch\bigvtbl\bigvtbl_cs_ro\bigvtbl_cs_ro.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }
public class _virtualstubdispatch_bigvtbl_bigvtbl_cs_r_bigvtbl_cs_r_
        {
            [Fact]
            public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_r_bigvtbl_cs_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.opt\virtualstubdispatch\bigvtbl\bigvtbl_cs_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"bigvtbl_cs_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\virtualstubdispatch\bigvtbl\bigvtbl_cs_r\bigvtbl_cs_r.cmd");
                  

                  if (!_Global.runningInWindows) {
                      testExecutable = testExecutable.Replace(".cmd", ".sh");
                  }

                  System.IO.Directory.CreateDirectory(_Global.reportBase + testSubfolder);

                  ret = wrapper.RunTest(testExecutable, outputFile, errorFile);
                }
                catch (Exception ex)
                {
                    infraEx = ex;
                }

                if (ret != CoreclrTestWrapperLib.EXIT_SUCCESS_CODE)
                {
                    string sErrorText = null;
                    try
                    {
                        sErrorText = System.IO.File.ReadAllText(errorFile);
                    }
                    catch(Exception ex)
                    {
                      sErrorText = "Unable to read error file: " + errorFile;
                    }

                    string outputText = null;
                    try
                    {
                        System.IO.StreamReader outputReader = new System.IO.StreamReader(outputFile);
                        outputText = outputReader.ReadToEnd();
                        outputReader.Close();
                    }
                    catch(Exception ex)
                    {
                        outputText = "Unable to read output file: " + outputFile;
                    }

                    string msg = infraEx != null ? "Test Infrastructure Failure: " + infraEx.Message
                                                 : sErrorText + "\n\n" +
                                                   "Return code:      " + ret + "\n" +
                                                   "Raw output file:      " + outputFile + "\n" +
                                                   "Raw output:\n" + outputText + "\n" +
                                                   "To run the test:\n" +
                                                   "> set CORE_ROOT=" + _Global.coreRoot + "\n" +
                                                   "> " + testExecutable + "\n";

                    Assert.True(ret == CoreclrTestWrapperLib.EXIT_SUCCESS_CODE, msg);
                }
            }
       }

}
