using Xunit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using CoreclrTestLib;

namespace JIT_Directed
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


public class _array_il__Arrayscomplex3__Arrayscomplex3_
        {
            [Fact]
            public void _array_il__Arrayscomplex3__Arrayscomplex3_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\array-il\_Arrayscomplex3\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"_Arrayscomplex3.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"_Arrayscomplex3.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\array-il\_Arrayscomplex3\_Arrayscomplex3.cmd");
                  

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
public class _cmov_Float_Xor_Op_cs_ro_Float_Xor_Op_cs_ro_
        {
            [Fact]
            public void _cmov_Float_Xor_Op_cs_ro_Float_Xor_Op_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\cmov\Float_Xor_Op_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Float_Xor_Op_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Float_Xor_Op_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\cmov\Float_Xor_Op_cs_ro\Float_Xor_Op_cs_ro.cmd");
                  

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
public class _cmov_Int_Or_Op_cs_do_Int_Or_Op_cs_do_
        {
            [Fact]
            public void _cmov_Int_Or_Op_cs_do_Int_Or_Op_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\cmov\Int_Or_Op_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Int_Or_Op_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Int_Or_Op_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\cmov\Int_Or_Op_cs_do\Int_Or_Op_cs_do.cmd");
                  

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
public class _cmov_Int_Or_Op_cs_ro_Int_Or_Op_cs_ro_
        {
            [Fact]
            public void _cmov_Int_Or_Op_cs_ro_Int_Or_Op_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\cmov\Int_Or_Op_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Int_Or_Op_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Int_Or_Op_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\cmov\Int_Or_Op_cs_ro\Int_Or_Op_cs_ro.cmd");
                  

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
public class _coverage_compiler_FilterToHandler_FilterToHandler_
        {
            [Fact]
            public void _coverage_compiler_FilterToHandler_FilterToHandler_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\compiler\FilterToHandler\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FilterToHandler.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FilterToHandler.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\compiler\FilterToHandler\FilterToHandler.cmd");
                  

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
public class _coverage_importer_badendfinally_badendfinally_
        {
            [Fact]
            public void _coverage_importer_badendfinally_badendfinally_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\badendfinally\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\badendfinally\badendfinally.cmd");
                  

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
public class _coverage_importer_ceeillegal_ceeillegal_
        {
            [Fact]
            public void _coverage_importer_ceeillegal_ceeillegal_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\ceeillegal\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\ceeillegal\ceeillegal.cmd");
                  

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
public class _coverage_importer_Desktop_badendfinally_il_d_badendfinally_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_badendfinally_il_d_badendfinally_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\badendfinally_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\badendfinally_il_d\badendfinally_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_badendfinally_il_r_badendfinally_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_badendfinally_il_r_badendfinally_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\badendfinally_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badendfinally_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\badendfinally_il_r\badendfinally_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_badldsfld_il_d_badldsfld_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_badldsfld_il_d_badldsfld_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\badldsfld_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badldsfld_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badldsfld_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\badldsfld_il_d\badldsfld_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_badldsfld_il_r_badldsfld_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_badldsfld_il_r_badldsfld_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\badldsfld_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badldsfld_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"badldsfld_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\badldsfld_il_r\badldsfld_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_ceeillegal_il_d_ceeillegal_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_ceeillegal_il_d_ceeillegal_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\ceeillegal_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\ceeillegal_il_d\ceeillegal_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_ceeillegal_il_r_ceeillegal_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_ceeillegal_il_r_ceeillegal_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\ceeillegal_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ceeillegal_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\ceeillegal_il_r\ceeillegal_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_ldelemnullarr2_il_d_ldelemnullarr2_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_ldelemnullarr2_il_d_ldelemnullarr2_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\ldelemnullarr2_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\ldelemnullarr2_il_d\ldelemnullarr2_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_ldelemnullarr2_il_r_ldelemnullarr2_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_ldelemnullarr2_il_r_ldelemnullarr2_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\ldelemnullarr2_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\ldelemnullarr2_il_r\ldelemnullarr2_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_nullsdarr_il_d_nullsdarr_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_nullsdarr_il_d_nullsdarr_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\nullsdarr_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\nullsdarr_il_d\nullsdarr_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_nullsdarr_il_r_nullsdarr_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_nullsdarr_il_r_nullsdarr_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\nullsdarr_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\nullsdarr_il_r\nullsdarr_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_volatilldind_il_d_volatilldind_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_volatilldind_il_d_volatilldind_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\volatilldind_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\volatilldind_il_d\volatilldind_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_volatilldind_il_r_volatilldind_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_volatilldind_il_r_volatilldind_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\volatilldind_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\volatilldind_il_r\volatilldind_il_r.cmd");
                  

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
public class _coverage_importer_Desktop_volatilstind_il_d_volatilstind_il_d_
        {
            [Fact]
            public void _coverage_importer_Desktop_volatilstind_il_d_volatilstind_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\volatilstind_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\volatilstind_il_d\volatilstind_il_d.cmd");
                  

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
public class _coverage_importer_Desktop_volatilstind_il_r_volatilstind_il_r_
        {
            [Fact]
            public void _coverage_importer_Desktop_volatilstind_il_r_volatilstind_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\Desktop\volatilstind_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\Desktop\volatilstind_il_r\volatilstind_il_r.cmd");
                  

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
public class _coverage_importer_ldelemnullarr2_ldelemnullarr2_
        {
            [Fact]
            public void _coverage_importer_ldelemnullarr2_ldelemnullarr2_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\ldelemnullarr2\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ldelemnullarr2.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\ldelemnullarr2\ldelemnullarr2.cmd");
                  

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
public class _coverage_importer_nullsdarr_nullsdarr_
        {
            [Fact]
            public void _coverage_importer_nullsdarr_nullsdarr_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\nullsdarr\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nullsdarr.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\nullsdarr\nullsdarr.cmd");
                  

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
public class _coverage_importer_volatilldind_volatilldind_
        {
            [Fact]
            public void _coverage_importer_volatilldind_volatilldind_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\volatilldind\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilldind.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\volatilldind\volatilldind.cmd");
                  

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
public class _coverage_importer_volatilstind_volatilstind_
        {
            [Fact]
            public void _coverage_importer_volatilstind_volatilstind_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\importer\volatilstind\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"volatilstind.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\importer\volatilstind\volatilstind.cmd");
                  

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
public class _coverage_oldtests_callipinvoke_callipinvoke_
        {
            [Fact]
            public void _coverage_oldtests_callipinvoke_callipinvoke_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\callipinvoke\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\callipinvoke\callipinvoke.cmd");
                  

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
public class _coverage_oldtests_cse2_cs_do_cse2_cs_do_
        {
            [Fact]
            public void _coverage_oldtests_cse2_cs_do_cse2_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\cse2_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cse2_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cse2_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\cse2_cs_do\cse2_cs_do.cmd");
                  

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
public class _coverage_oldtests_cse2_cs_ro_cse2_cs_ro_
        {
            [Fact]
            public void _coverage_oldtests_cse2_cs_ro_cse2_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\cse2_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cse2_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cse2_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\cse2_cs_ro\cse2_cs_ro.cmd");
                  

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
public class _coverage_oldtests_Desktop_callipinvoke_il_d_callipinvoke_il_d_
        {
            [Fact]
            public void _coverage_oldtests_Desktop_callipinvoke_il_d_callipinvoke_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\Desktop\callipinvoke_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\Desktop\callipinvoke_il_d\callipinvoke_il_d.cmd");
                  

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
public class _coverage_oldtests_Desktop_callipinvoke_il_r_callipinvoke_il_r_
        {
            [Fact]
            public void _coverage_oldtests_Desktop_callipinvoke_il_r_callipinvoke_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\Desktop\callipinvoke_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callipinvoke_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\Desktop\callipinvoke_il_r\callipinvoke_il_r.cmd");
                  

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
public class _coverage_oldtests_lclfldadd_cs_r_lclfldadd_cs_r_
        {
            [Fact]
            public void _coverage_oldtests_lclfldadd_cs_r_lclfldadd_cs_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\lclfldadd_cs_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"lclfldadd_cs_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"lclfldadd_cs_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\lclfldadd_cs_r\lclfldadd_cs_r.cmd");
                  

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
public class _coverage_oldtests_ovfldiv1_il_d_ovfldiv1_il_d_
        {
            [Fact]
            public void _coverage_oldtests_ovfldiv1_il_d_ovfldiv1_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovfldiv1_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv1_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv1_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovfldiv1_il_d\ovfldiv1_il_d.cmd");
                  

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
public class _coverage_oldtests_ovfldiv1_il_r_ovfldiv1_il_r_
        {
            [Fact]
            public void _coverage_oldtests_ovfldiv1_il_r_ovfldiv1_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovfldiv1_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv1_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv1_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovfldiv1_il_r\ovfldiv1_il_r.cmd");
                  

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
public class _coverage_oldtests_ovfldiv2_il_d_ovfldiv2_il_d_
        {
            [Fact]
            public void _coverage_oldtests_ovfldiv2_il_d_ovfldiv2_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovfldiv2_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv2_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv2_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovfldiv2_il_d\ovfldiv2_il_d.cmd");
                  

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
public class _coverage_oldtests_ovfldiv2_il_r_ovfldiv2_il_r_
        {
            [Fact]
            public void _coverage_oldtests_ovfldiv2_il_r_ovfldiv2_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovfldiv2_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv2_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovfldiv2_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovfldiv2_il_r\ovfldiv2_il_r.cmd");
                  

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
public class _coverage_oldtests_ovflrem1_il_d_ovflrem1_il_d_
        {
            [Fact]
            public void _coverage_oldtests_ovflrem1_il_d_ovflrem1_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovflrem1_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem1_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem1_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovflrem1_il_d\ovflrem1_il_d.cmd");
                  

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
public class _coverage_oldtests_ovflrem1_il_r_ovflrem1_il_r_
        {
            [Fact]
            public void _coverage_oldtests_ovflrem1_il_r_ovflrem1_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovflrem1_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem1_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem1_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovflrem1_il_r\ovflrem1_il_r.cmd");
                  

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
public class _coverage_oldtests_ovflrem2_il_d_ovflrem2_il_d_
        {
            [Fact]
            public void _coverage_oldtests_ovflrem2_il_d_ovflrem2_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovflrem2_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem2_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem2_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovflrem2_il_d\ovflrem2_il_d.cmd");
                  

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
public class _coverage_oldtests_ovflrem2_il_r_ovflrem2_il_r_
        {
            [Fact]
            public void _coverage_oldtests_ovflrem2_il_r_ovflrem2_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\ovflrem2_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem2_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ovflrem2_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\ovflrem2_il_r\ovflrem2_il_r.cmd");
                  

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
public class _coverage_oldtests_trashreg_il_d_trashreg_il_d_
        {
            [Fact]
            public void _coverage_oldtests_trashreg_il_d_trashreg_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\trashreg_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"trashreg_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"trashreg_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\trashreg_il_d\trashreg_il_d.cmd");
                  

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
public class _coverage_oldtests_trashreg_il_r_trashreg_il_r_
        {
            [Fact]
            public void _coverage_oldtests_trashreg_il_r_trashreg_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\coverage\oldtests\trashreg_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"trashreg_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"trashreg_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\coverage\oldtests\trashreg_il_r\trashreg_il_r.cmd");
                  

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
public class _ExcepFilters_excepobj_excepobj_excepobj_
        {
            [Fact]
            public void _ExcepFilters_excepobj_excepobj_excepobj_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\ExcepFilters\excepobj\excepobj\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"excepobj.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"excepobj.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ExcepFilters\excepobj\excepobj\excepobj.cmd");
                  

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
public class _ExcepFilters_fault_fault_fault_
        {
            [Fact]
            public void _ExcepFilters_fault_fault_fault_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\ExcepFilters\fault\fault\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"fault.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"fault.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ExcepFilters\fault\fault\fault.cmd");
                  

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
public class _ExcepFilters_mixed3_mixed3_mixed3_
        {
            [Fact]
            public void _ExcepFilters_mixed3_mixed3_mixed3_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\ExcepFilters\mixed3\mixed3\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed3.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed3.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ExcepFilters\mixed3\mixed3\mixed3.cmd");
                  

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
public class _forceinlining_NegativeCases_NegativeCases_
        {
            [Fact]
            public void _forceinlining_NegativeCases_NegativeCases_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\forceinlining\NegativeCases\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"NegativeCases.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"NegativeCases.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\forceinlining\NegativeCases\NegativeCases.cmd");
                  

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
public class _gettypetypeof_gettypetypeofmatrix_gettypetypeofmatrix_
        {
            [Fact]
            public void _gettypetypeof_gettypetypeofmatrix_gettypetypeofmatrix_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\gettypetypeof\gettypetypeofmatrix\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettypetypeofmatrix.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettypetypeofmatrix.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\gettypetypeof\gettypetypeofmatrix\gettypetypeofmatrix.cmd");
                  

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
public class _IL_leave_leave1_leave1_
        {
            [Fact]
            public void _IL_leave_leave1_leave1_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\leave\leave1\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"leave1.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"leave1.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\leave\leave1\leave1.cmd");
                  

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
public class _IL_mutualrecur_tailcall_MutualRecur_TailCall_MutualRecur_TailCall_
        {
            [Fact]
            public void _IL_mutualrecur_tailcall_MutualRecur_TailCall_MutualRecur_TailCall_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\mutualrecur-tailcall\MutualRecur-TailCall\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"MutualRecur-TailCall.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"MutualRecur-TailCall.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\mutualrecur-tailcall\MutualRecur-TailCall\MutualRecur-TailCall.cmd");
                  

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
public class _IL_PInvokeTail_TailWinApi_TailWinApi_
        {
            [Fact]
            public void _IL_PInvokeTail_TailWinApi_TailWinApi_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\PInvokeTail\TailWinApi\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailWinApi.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"TailWinApi.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\PInvokeTail\TailWinApi\TailWinApi.cmd");
                  

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
public class _IL_rethrow_Rethrow1_Rethrow1_
        {
            [Fact]
            public void _IL_rethrow_Rethrow1_Rethrow1_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\rethrow\Rethrow1\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Rethrow1.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Rethrow1.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\rethrow\Rethrow1\Rethrow1.cmd");
                  

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
public class _IL_rethrow_Rethrow2_Rethrow2_
        {
            [Fact]
            public void _IL_rethrow_Rethrow2_Rethrow2_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\rethrow\Rethrow2\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Rethrow2.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Rethrow2.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\rethrow\Rethrow2\Rethrow2.cmd");
                  

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
public class _IL_Tailcall_jitTailcall1_jitTailcall1_
        {
            [Fact]
            public void _IL_Tailcall_jitTailcall1_jitTailcall1_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\Tailcall\jitTailcall1\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"jitTailcall1.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"jitTailcall1.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\Tailcall\jitTailcall1\jitTailcall1.cmd");
                  

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
public class _IL_Tailcall_JitTailcall2_JitTailcall2_
        {
            [Fact]
            public void _IL_Tailcall_JitTailcall2_JitTailcall2_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\IL\Tailcall\JitTailcall2\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"JitTailcall2.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"JitTailcall2.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\IL\Tailcall\JitTailcall2\JitTailcall2.cmd");
                  

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
public class _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_
        {
            [Fact]
            public void _Misc_function_pointer_MutualThdRecur_fptr_MutualThdRecur_fptr_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\Misc\function_pointer\MutualThdRecur-fptr\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"MutualThdRecur-fptr.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"MutualThdRecur-fptr.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Misc\function_pointer\MutualThdRecur-fptr\MutualThdRecur-fptr.cmd");
                  

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
public class _Misc_gettype_gettypetypeofmatrix_gettypetypeofmatrix_
        {
            [Fact]
            public void _Misc_gettype_gettypetypeofmatrix_gettypetypeofmatrix_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\Misc\gettype\gettypetypeofmatrix\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettypetypeofmatrix.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gettypetypeofmatrix.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Misc\gettype\gettypetypeofmatrix\gettypetypeofmatrix.cmd");
                  

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
public class _newarr_newarr_newarr_
        {
            [Fact]
            public void _newarr_newarr_newarr_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\newarr\newarr\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"newarr.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"newarr.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\newarr\newarr\newarr.cmd");
                  

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
public class _nullabletypes_boxunboxenum_do_boxunboxenum_do_
        {
            [Fact]
            public void _nullabletypes_boxunboxenum_do_boxunboxenum_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxenum_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxenum_do\boxunboxenum_do.cmd");
                  

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
public class _nullabletypes_boxunboxenum_d_boxunboxenum_d_
        {
            [Fact]
            public void _nullabletypes_boxunboxenum_d_boxunboxenum_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxenum_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxenum_d\boxunboxenum_d.cmd");
                  

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
public class _nullabletypes_boxunboxenum_ro_boxunboxenum_ro_
        {
            [Fact]
            public void _nullabletypes_boxunboxenum_ro_boxunboxenum_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxenum_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxenum_ro\boxunboxenum_ro.cmd");
                  

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
public class _nullabletypes_boxunboxenum_r_boxunboxenum_r_
        {
            [Fact]
            public void _nullabletypes_boxunboxenum_r_boxunboxenum_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxenum_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxenum_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxenum_r\boxunboxenum_r.cmd");
                  

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
public class _nullabletypes_boxunboxinterface_do_boxunboxinterface_do_
        {
            [Fact]
            public void _nullabletypes_boxunboxinterface_do_boxunboxinterface_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxinterface_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxinterface_do\boxunboxinterface_do.cmd");
                  

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
public class _nullabletypes_boxunboxinterface_d_boxunboxinterface_d_
        {
            [Fact]
            public void _nullabletypes_boxunboxinterface_d_boxunboxinterface_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxinterface_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxinterface_d\boxunboxinterface_d.cmd");
                  

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
public class _nullabletypes_boxunboxinterface_ro_boxunboxinterface_ro_
        {
            [Fact]
            public void _nullabletypes_boxunboxinterface_ro_boxunboxinterface_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxinterface_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxinterface_ro\boxunboxinterface_ro.cmd");
                  

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
public class _nullabletypes_boxunboxinterface_r_boxunboxinterface_r_
        {
            [Fact]
            public void _nullabletypes_boxunboxinterface_r_boxunboxinterface_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\boxunboxinterface_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxinterface_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\boxunboxinterface_r\boxunboxinterface_r.cmd");
                  

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
public class _nullabletypes_castclassenum_do_castclassenum_do_
        {
            [Fact]
            public void _nullabletypes_castclassenum_do_castclassenum_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassenum_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassenum_do\castclassenum_do.cmd");
                  

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
public class _nullabletypes_castclassenum_d_castclassenum_d_
        {
            [Fact]
            public void _nullabletypes_castclassenum_d_castclassenum_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassenum_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassenum_d\castclassenum_d.cmd");
                  

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
public class _nullabletypes_castclassenum_ro_castclassenum_ro_
        {
            [Fact]
            public void _nullabletypes_castclassenum_ro_castclassenum_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassenum_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassenum_ro\castclassenum_ro.cmd");
                  

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
public class _nullabletypes_castclassenum_r_castclassenum_r_
        {
            [Fact]
            public void _nullabletypes_castclassenum_r_castclassenum_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassenum_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassenum_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassenum_r\castclassenum_r.cmd");
                  

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
public class _nullabletypes_castclassinterface_do_castclassinterface_do_
        {
            [Fact]
            public void _nullabletypes_castclassinterface_do_castclassinterface_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassinterface_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassinterface_do\castclassinterface_do.cmd");
                  

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
public class _nullabletypes_castclassinterface_d_castclassinterface_d_
        {
            [Fact]
            public void _nullabletypes_castclassinterface_d_castclassinterface_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassinterface_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassinterface_d\castclassinterface_d.cmd");
                  

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
public class _nullabletypes_castclassinterface_ro_castclassinterface_ro_
        {
            [Fact]
            public void _nullabletypes_castclassinterface_ro_castclassinterface_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassinterface_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassinterface_ro\castclassinterface_ro.cmd");
                  

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
public class _nullabletypes_castclassinterface_r_castclassinterface_r_
        {
            [Fact]
            public void _nullabletypes_castclassinterface_r_castclassinterface_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassinterface_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassinterface_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassinterface_r\castclassinterface_r.cmd");
                  

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
public class _nullabletypes_castclassvaluetype_do_castclassvaluetype_do_
        {
            [Fact]
            public void _nullabletypes_castclassvaluetype_do_castclassvaluetype_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassvaluetype_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassvaluetype_do\castclassvaluetype_do.cmd");
                  

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
public class _nullabletypes_castclassvaluetype_d_castclassvaluetype_d_
        {
            [Fact]
            public void _nullabletypes_castclassvaluetype_d_castclassvaluetype_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassvaluetype_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassvaluetype_d\castclassvaluetype_d.cmd");
                  

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
public class _nullabletypes_castclassvaluetype_ro_castclassvaluetype_ro_
        {
            [Fact]
            public void _nullabletypes_castclassvaluetype_ro_castclassvaluetype_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassvaluetype_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassvaluetype_ro\castclassvaluetype_ro.cmd");
                  

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
public class _nullabletypes_castclassvaluetype_r_castclassvaluetype_r_
        {
            [Fact]
            public void _nullabletypes_castclassvaluetype_r_castclassvaluetype_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\castclassvaluetype_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"castclassvaluetype_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\castclassvaluetype_r\castclassvaluetype_r.cmd");
                  

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
public class _nullabletypes_Desktop_boxunboxvaluetype_do_boxunboxvaluetype_do_
        {
            [Fact]
            public void _nullabletypes_Desktop_boxunboxvaluetype_do_boxunboxvaluetype_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\Desktop\boxunboxvaluetype_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\Desktop\boxunboxvaluetype_do\boxunboxvaluetype_do.cmd");
                  

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
public class _nullabletypes_Desktop_boxunboxvaluetype_ro_boxunboxvaluetype_ro_
        {
            [Fact]
            public void _nullabletypes_Desktop_boxunboxvaluetype_ro_boxunboxvaluetype_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\Desktop\boxunboxvaluetype_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\Desktop\boxunboxvaluetype_ro\boxunboxvaluetype_ro.cmd");
                  

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
public class _nullabletypes_Desktop_boxunboxvaluetype_r_boxunboxvaluetype_r_
        {
            [Fact]
            public void _nullabletypes_Desktop_boxunboxvaluetype_r_boxunboxvaluetype_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\Desktop\boxunboxvaluetype_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"boxunboxvaluetype_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\Desktop\boxunboxvaluetype_r\boxunboxvaluetype_r.cmd");
                  

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
public class _nullabletypes_hashcode_do_hashcode_do_
        {
            [Fact]
            public void _nullabletypes_hashcode_do_hashcode_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\hashcode_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\hashcode_do\hashcode_do.cmd");
                  

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
public class _nullabletypes_hashcode_d_hashcode_d_
        {
            [Fact]
            public void _nullabletypes_hashcode_d_hashcode_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\hashcode_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\hashcode_d\hashcode_d.cmd");
                  

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
public class _nullabletypes_hashcode_ro_hashcode_ro_
        {
            [Fact]
            public void _nullabletypes_hashcode_ro_hashcode_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\hashcode_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\hashcode_ro\hashcode_ro.cmd");
                  

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
public class _nullabletypes_hashcode_r_hashcode_r_
        {
            [Fact]
            public void _nullabletypes_hashcode_r_hashcode_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\hashcode_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"hashcode_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\hashcode_r\hashcode_r.cmd");
                  

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
public class _nullabletypes_isinstvaluetype_do_isinstvaluetype_do_
        {
            [Fact]
            public void _nullabletypes_isinstvaluetype_do_isinstvaluetype_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\isinstvaluetype_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"isinstvaluetype_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"isinstvaluetype_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\isinstvaluetype_do\isinstvaluetype_do.cmd");
                  

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
public class _nullabletypes_isinst_do_isinst_do_
        {
            [Fact]
            public void _nullabletypes_isinst_do_isinst_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\isinst_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"isinst_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"isinst_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\isinst_do\isinst_do.cmd");
                  

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
public class _nullabletypes_unboxnullable_do_unboxnullable_do_
        {
            [Fact]
            public void _nullabletypes_unboxnullable_do_unboxnullable_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\unboxnullable_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\unboxnullable_do\unboxnullable_do.cmd");
                  

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
public class _nullabletypes_unboxnullable_d_unboxnullable_d_
        {
            [Fact]
            public void _nullabletypes_unboxnullable_d_unboxnullable_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\unboxnullable_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\unboxnullable_d\unboxnullable_d.cmd");
                  

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
public class _nullabletypes_unboxnullable_ro_unboxnullable_ro_
        {
            [Fact]
            public void _nullabletypes_unboxnullable_ro_unboxnullable_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\unboxnullable_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\unboxnullable_ro\unboxnullable_ro.cmd");
                  

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
public class _nullabletypes_unboxnullable_r_unboxnullable_r_
        {
            [Fact]
            public void _nullabletypes_unboxnullable_r_unboxnullable_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\unboxnullable_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"unboxnullable_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\unboxnullable_r\unboxnullable_r.cmd");
                  

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
public class _nullabletypes_value_do_value_do_
        {
            [Fact]
            public void _nullabletypes_value_do_value_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\value_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\value_do\value_do.cmd");
                  

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
public class _nullabletypes_value_d_value_d_
        {
            [Fact]
            public void _nullabletypes_value_d_value_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\value_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\value_d\value_d.cmd");
                  

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
public class _nullabletypes_value_ro_value_ro_
        {
            [Fact]
            public void _nullabletypes_value_ro_value_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\value_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\value_ro\value_ro.cmd");
                  

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
public class _nullabletypes_value_r_value_r_
        {
            [Fact]
            public void _nullabletypes_value_r_value_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\nullabletypes\value_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"value_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\nullabletypes\value_r\value_r.cmd");
                  

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
public class _perffix_primitivevt_callconv3_il_d_callconv3_il_d_
        {
            [Fact]
            public void _perffix_primitivevt_callconv3_il_d_callconv3_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\callconv3_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callconv3_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callconv3_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\callconv3_il_d\callconv3_il_d.cmd");
                  

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
public class _perffix_primitivevt_callconv3_il_r_callconv3_il_r_
        {
            [Fact]
            public void _perffix_primitivevt_callconv3_il_r_callconv3_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\callconv3_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callconv3_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"callconv3_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\callconv3_il_r\callconv3_il_r.cmd");
                  

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
public class _perffix_primitivevt_identity3_il_d_identity3_il_d_
        {
            [Fact]
            public void _perffix_primitivevt_identity3_il_d_identity3_il_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\identity3_il_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"identity3_il_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"identity3_il_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\identity3_il_d\identity3_il_d.cmd");
                  

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
public class _perffix_primitivevt_identity3_il_r_identity3_il_r_
        {
            [Fact]
            public void _perffix_primitivevt_identity3_il_r_identity3_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\identity3_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"identity3_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"identity3_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\identity3_il_r\identity3_il_r.cmd");
                  

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
public class _perffix_primitivevt_mixed1_cs_do_mixed1_cs_do_
        {
            [Fact]
            public void _perffix_primitivevt_mixed1_cs_do_mixed1_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\mixed1_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed1_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed1_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\mixed1_cs_do\mixed1_cs_do.cmd");
                  

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
public class _perffix_primitivevt_mixed1_cs_ro_mixed1_cs_ro_
        {
            [Fact]
            public void _perffix_primitivevt_mixed1_cs_ro_mixed1_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\perffix\primitivevt\mixed1_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed1_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"mixed1_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\perffix\primitivevt\mixed1_cs_ro\mixed1_cs_ro.cmd");
                  

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
public class _pinvoke_calli_excep_calli_excep_
        {
            [Fact]
            public void _pinvoke_calli_excep_calli_excep_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\pinvoke\calli_excep\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"calli_excep.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"calli_excep.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\pinvoke\calli_excep\calli_excep.cmd");
                  

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
public class _pinvoke_tail_tail_
        {
            [Fact]
            public void _pinvoke_tail_tail_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\pinvoke\tail\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tail.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tail.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\pinvoke\tail\tail.cmd");
                  

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
public class _PREFIX_volatile_1_cpblk_cpblk_
        {
            [Fact]
            public void _PREFIX_volatile_1_cpblk_cpblk_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\PREFIX\volatile\1\cpblk\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cpblk.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"cpblk.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\PREFIX\volatile\1\cpblk\cpblk.cmd");
                  

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
public class _shift_uint16_ro_uint16_ro_
        {
            [Fact]
            public void _shift_uint16_ro_uint16_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\shift\uint16_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"uint16_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"uint16_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\shift\uint16_ro\uint16_ro.cmd");
                  

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
public class _StrAccess_straccess1_cs_ro_straccess1_cs_ro_
        {
            [Fact]
            public void _StrAccess_straccess1_cs_ro_straccess1_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess1_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess1_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess1_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess1_cs_ro\straccess1_cs_ro.cmd");
                  

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
public class _StrAccess_straccess2_cs_do_straccess2_cs_do_
        {
            [Fact]
            public void _StrAccess_straccess2_cs_do_straccess2_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess2_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess2_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess2_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess2_cs_do\straccess2_cs_do.cmd");
                  

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
public class _StrAccess_straccess2_cs_ro_straccess2_cs_ro_
        {
            [Fact]
            public void _StrAccess_straccess2_cs_ro_straccess2_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess2_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess2_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess2_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess2_cs_ro\straccess2_cs_ro.cmd");
                  

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
public class _StrAccess_straccess3_cs_do_straccess3_cs_do_
        {
            [Fact]
            public void _StrAccess_straccess3_cs_do_straccess3_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess3_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess3_cs_do\straccess3_cs_do.cmd");
                  

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
public class _StrAccess_straccess3_cs_d_straccess3_cs_d_
        {
            [Fact]
            public void _StrAccess_straccess3_cs_d_straccess3_cs_d_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess3_cs_d\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_d.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_d.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess3_cs_d\straccess3_cs_d.cmd");
                  

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
public class _StrAccess_straccess3_cs_ro_straccess3_cs_ro_
        {
            [Fact]
            public void _StrAccess_straccess3_cs_ro_straccess3_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess3_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess3_cs_ro\straccess3_cs_ro.cmd");
                  

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
public class _StrAccess_straccess3_cs_r_straccess3_cs_r_
        {
            [Fact]
            public void _StrAccess_straccess3_cs_r_straccess3_cs_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess3_cs_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess3_cs_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess3_cs_r\straccess3_cs_r.cmd");
                  

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
public class _StrAccess_straccess4_straccess4_
        {
            [Fact]
            public void _StrAccess_straccess4_straccess4_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\StrAccess\straccess4\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess4.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"straccess4.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StrAccess\straccess4\straccess4.cmd");
                  

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
public class _tailcall_tailcall_tailcall_
        {
            [Fact]
            public void _tailcall_tailcall_tailcall_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\tailcall\tailcall\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tailcall.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tailcall.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\tailcall\tailcall\tailcall.cmd");
                  

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
public class _throwbox_fault_fault_
        {
            [Fact]
            public void _throwbox_fault_fault_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\throwbox\fault\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"fault.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"fault.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\throwbox\fault\fault.cmd");
                  

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
public class _throwbox_filter_filter_
        {
            [Fact]
            public void _throwbox_filter_filter_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\throwbox\filter\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"filter.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"filter.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\throwbox\filter\filter.cmd");
                  

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
public class _throwbox_finally_finally_
        {
            [Fact]
            public void _throwbox_finally_finally_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\throwbox\finally\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"finally.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"finally.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\throwbox\finally\finally.cmd");
                  

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
public class _throwbox_rethrow_rethrow_
        {
            [Fact]
            public void _throwbox_rethrow_rethrow_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\throwbox\rethrow\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rethrow.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rethrow.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\throwbox\rethrow\rethrow.cmd");
                  

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
public class _UnrollLoop_loop3_il_r_loop3_il_r_
        {
            [Fact]
            public void _UnrollLoop_loop3_il_r_loop3_il_r_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\UnrollLoop\loop3_il_r\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop3_il_r.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop3_il_r.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\UnrollLoop\loop3_il_r\loop3_il_r.cmd");
                  

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
public class _UnrollLoop_loop4_cs_do_loop4_cs_do_
        {
            [Fact]
            public void _UnrollLoop_loop4_cs_do_loop4_cs_do_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\UnrollLoop\loop4_cs_do\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop4_cs_do.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop4_cs_do.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\UnrollLoop\loop4_cs_do\loop4_cs_do.cmd");
                  

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
public class _UnrollLoop_loop4_cs_ro_loop4_cs_ro_
        {
            [Fact]
            public void _UnrollLoop_loop4_cs_ro_loop4_cs_ro_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\UnrollLoop\loop4_cs_ro\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop4_cs_ro.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"loop4_cs_ro.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\UnrollLoop\loop4_cs_ro\loop4_cs_ro.cmd");
                  

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
public class _zeroinit_Dev10_863995_Dev10_863995_
        {
            [Fact]
            public void _zeroinit_Dev10_863995_Dev10_863995_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\zeroinit\Dev10_863995\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Dev10_863995.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"Dev10_863995.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\zeroinit\Dev10_863995\Dev10_863995.cmd");
                  

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
public class _zeroinit_init_struct_init_struct_
        {
            [Fact]
            public void _zeroinit_init_struct_init_struct_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\zeroinit\init_struct\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"init_struct.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"init_struct.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\zeroinit\init_struct\init_struct.cmd");
                  

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
public class _zeroinit_tail_tail_
        {
            [Fact]
            public void _zeroinit_tail_tail_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\JIT.Directed\zeroinit\tail\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tail.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"tail.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\zeroinit\tail\tail.cmd");
                  

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
