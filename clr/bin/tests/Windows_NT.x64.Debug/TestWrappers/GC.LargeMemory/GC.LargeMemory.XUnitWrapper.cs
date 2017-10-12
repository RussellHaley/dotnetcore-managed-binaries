using Xunit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using CoreclrTestLib;

namespace GC_LargeMemory
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


public class _API_gc_gettotalmemory_gettotalmemory_
        {
            [Fact]
            public void _API_gc_gettotalmemory_gettotalmemory_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.LargeMemory\API\gc\gettotalmemory\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettotalmemory.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettotalmemory.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\API\gc\gettotalmemory\gettotalmemory.cmd");
                  

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
public class _Regressions_largearraytest_largearraytest_
        {
            [Fact]
            public void _Regressions_largearraytest_largearraytest_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.LargeMemory\Regressions\largearraytest\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"largearraytest.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"largearraytest.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Regressions\largearraytest\largearraytest.cmd");
                  

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
public class _Regressions_pressureoverflow_pressureoverflow_
        {
            [Fact]
            public void _Regressions_pressureoverflow_pressureoverflow_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.LargeMemory\Regressions\pressureoverflow\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"pressureoverflow.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"pressureoverflow.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Regressions\pressureoverflow\pressureoverflow.cmd");
                  

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
