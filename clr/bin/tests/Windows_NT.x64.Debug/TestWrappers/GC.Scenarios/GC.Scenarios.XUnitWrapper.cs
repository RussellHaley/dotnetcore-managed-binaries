using Xunit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using CoreclrTestLib;

namespace GC_Scenarios
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


public class _BinTree_thdtreegrowingobj_thdtreegrowingobj_
        {
            [Fact]
            public void _BinTree_thdtreegrowingobj_thdtreegrowingobj_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\BinTree\thdtreegrowingobj\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtreegrowingobj.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtreegrowingobj.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\BinTree\thdtreegrowingobj\thdtreegrowingobj.cmd");
                  

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
public class _BinTree_thdtreelivingobj_thdtreelivingobj_
        {
            [Fact]
            public void _BinTree_thdtreelivingobj_thdtreelivingobj_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\BinTree\thdtreelivingobj\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtreelivingobj.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtreelivingobj.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\BinTree\thdtreelivingobj\thdtreelivingobj.cmd");
                  

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
public class _BinTree_thdtree_thdtree_
        {
            [Fact]
            public void _BinTree_thdtree_thdtree_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\BinTree\thdtree\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtree.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdtree.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\BinTree\thdtree\thdtree.cmd");
                  

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
public class _Boxing_arrcpy_arrcpy_
        {
            [Fact]
            public void _Boxing_arrcpy_arrcpy_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\arrcpy\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"arrcpy.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"arrcpy.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\arrcpy\arrcpy.cmd");
                  

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
public class _Boxing_gcvariant2_gcvariant2_
        {
            [Fact]
            public void _Boxing_gcvariant2_gcvariant2_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\gcvariant2\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant2.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant2.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\gcvariant2\gcvariant2.cmd");
                  

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
public class _Boxing_gcvariant3_gcvariant3_
        {
            [Fact]
            public void _Boxing_gcvariant3_gcvariant3_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\gcvariant3\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant3.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant3.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\gcvariant3\gcvariant3.cmd");
                  

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
public class _Boxing_gcvariant4_gcvariant4_
        {
            [Fact]
            public void _Boxing_gcvariant4_gcvariant4_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\gcvariant4\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant4.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant4.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\gcvariant4\gcvariant4.cmd");
                  

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
public class _Boxing_gcvariant_gcvariant_
        {
            [Fact]
            public void _Boxing_gcvariant_gcvariant_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\gcvariant\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcvariant.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\gcvariant\gcvariant.cmd");
                  

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
public class _Boxing_variantint_variantint_
        {
            [Fact]
            public void _Boxing_variantint_variantint_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\variantint\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"variantint.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"variantint.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\variantint\variantint.cmd");
                  

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
public class _Boxing_variantlinklist_variantlinklist_
        {
            [Fact]
            public void _Boxing_variantlinklist_variantlinklist_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Boxing\variantlinklist\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"variantlinklist.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"variantlinklist.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Boxing\variantlinklist\variantlinklist.cmd");
                  

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
public class _DoublinkList_dlbigleakthd_dlbigleakthd_
        {
            [Fact]
            public void _DoublinkList_dlbigleakthd_dlbigleakthd_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\dlbigleakthd\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlbigleakthd.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlbigleakthd.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\dlbigleakthd\dlbigleakthd.cmd");
                  

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
public class _DoublinkList_dlcollect_dlcollect_
        {
            [Fact]
            public void _DoublinkList_dlcollect_dlcollect_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\dlcollect\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlcollect.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlcollect.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\dlcollect\dlcollect.cmd");
                  

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
public class _DoublinkList_dlstack_dlstack_
        {
            [Fact]
            public void _DoublinkList_dlstack_dlstack_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\dlstack\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlstack.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dlstack.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\dlstack\dlstack.cmd");
                  

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
public class _DoublinkList_doublinkgen_doublinkgen_
        {
            [Fact]
            public void _DoublinkList_doublinkgen_doublinkgen_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\doublinkgen\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinkgen.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinkgen.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\doublinkgen\doublinkgen.cmd");
                  

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
public class _DoublinkList_doublinknoleak2_doublinknoleak2_
        {
            [Fact]
            public void _DoublinkList_doublinknoleak2_doublinknoleak2_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\doublinknoleak2\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinknoleak2.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinknoleak2.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\doublinknoleak2\doublinknoleak2.cmd");
                  

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
public class _DoublinkList_doublinkstay_doublinkstay_
        {
            [Fact]
            public void _DoublinkList_doublinkstay_doublinkstay_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\DoublinkList\doublinkstay\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinkstay.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"doublinkstay.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\DoublinkList\doublinkstay\doublinkstay.cmd");
                  

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
public class _Dynamo_dynamo_dynamo_
        {
            [Fact]
            public void _Dynamo_dynamo_dynamo_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Dynamo\dynamo\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dynamo.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"dynamo.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Dynamo\dynamo\dynamo.cmd");
                  

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
public class _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_
        {
            [Fact]
            public void _FinalizeTimeout_FinalizeTimeout_FinalizeTimeout_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\FinalizeTimeout\FinalizeTimeout\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FinalizeTimeout.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"FinalizeTimeout.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FinalizeTimeout\FinalizeTimeout\FinalizeTimeout.cmd");
                  

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
public class _FinalNStruct_finalnstruct_finalnstruct_
        {
            [Fact]
            public void _FinalNStruct_finalnstruct_finalnstruct_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\FinalNStruct\finalnstruct\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"finalnstruct.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"finalnstruct.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FinalNStruct\finalnstruct\finalnstruct.cmd");
                  

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
public class _FinalNStruct_nstructresur_nstructresur_
        {
            [Fact]
            public void _FinalNStruct_nstructresur_nstructresur_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\FinalNStruct\nstructresur\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nstructresur.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nstructresur.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FinalNStruct\nstructresur\nstructresur.cmd");
                  

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
public class _FinalNStruct_nstructtun_nstructtun_
        {
            [Fact]
            public void _FinalNStruct_nstructtun_nstructtun_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\FinalNStruct\nstructtun\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nstructtun.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"nstructtun.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\FinalNStruct\nstructtun\nstructtun.cmd");
                  

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
public class _GCBench_gcbench_gcbench_
        {
            [Fact]
            public void _GCBench_gcbench_gcbench_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\GCBench\gcbench\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcbench.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcbench.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\GCBench\gcbench\gcbench.cmd");
                  

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
public class _GCStress_gcstress_gcstress_
        {
            [Fact]
            public void _GCStress_gcstress_gcstress_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\GCStress\gcstress\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcstress.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"gcstress.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\GCStress\gcstress\gcstress.cmd");
                  

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
public class _LeakWheel_leakwheel_leakwheel_
        {
            [Fact]
            public void _LeakWheel_leakwheel_leakwheel_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\LeakWheel\leakwheel\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"leakwheel.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"leakwheel.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\LeakWheel\leakwheel\leakwheel.cmd");
                  

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
public class _MinLeakGen_minleakgen_minleakgen_
        {
            [Fact]
            public void _MinLeakGen_minleakgen_minleakgen_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\MinLeakGen\minleakgen\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"minleakgen.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"minleakgen.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\MinLeakGen\minleakgen\minleakgen.cmd");
                  

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
public class _NDPin_ndpinfinal_ndpinfinal_
        {
            [Fact]
            public void _NDPin_ndpinfinal_ndpinfinal_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\NDPin\ndpinfinal\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ndpinfinal.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ndpinfinal.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\NDPin\ndpinfinal\ndpinfinal.cmd");
                  

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
public class _NDPin_ndpin_ndpin_
        {
            [Fact]
            public void _NDPin_ndpin_ndpin_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\NDPin\ndpin\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ndpin.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"ndpin.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\NDPin\ndpin\ndpin.cmd");
                  

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
public class _RanCollect_rancollect_rancollect_
        {
            [Fact]
            public void _RanCollect_rancollect_rancollect_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\RanCollect\rancollect\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rancollect.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rancollect.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\RanCollect\rancollect\rancollect.cmd");
                  

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
public class _ReflectObj_reflectobj_reflectobj_
        {
            [Fact]
            public void _ReflectObj_reflectobj_reflectobj_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\ReflectObj\reflectobj\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"reflectobj.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"reflectobj.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ReflectObj\reflectobj\reflectobj.cmd");
                  

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
public class _Resurrection_continue_continue_
        {
            [Fact]
            public void _Resurrection_continue_continue_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Resurrection\continue\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"continue.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"continue.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Resurrection\continue\continue.cmd");
                  

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
public class _Rootmem_rootmem_rootmem_
        {
            [Fact]
            public void _Rootmem_rootmem_rootmem_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\Rootmem\rootmem\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rootmem.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"rootmem.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\Rootmem\rootmem\rootmem.cmd");
                  

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
public class _ServerModel_servermodel_servermodel_
        {
            [Fact]
            public void _ServerModel_servermodel_servermodel_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\ServerModel\servermodel\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"servermodel.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"servermodel.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\ServerModel\servermodel\servermodel.cmd");
                  

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
public class _SingLinkList_singlinkgen_singlinkgen_
        {
            [Fact]
            public void _SingLinkList_singlinkgen_singlinkgen_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\SingLinkList\singlinkgen\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"singlinkgen.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"singlinkgen.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\SingLinkList\singlinkgen\singlinkgen.cmd");
                  

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
public class _SingLinkList_singlinkstay_singlinkstay_
        {
            [Fact]
            public void _SingLinkList_singlinkstay_singlinkstay_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\SingLinkList\singlinkstay\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"singlinkstay.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"singlinkstay.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\SingLinkList\singlinkstay\singlinkstay.cmd");
                  

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
public class _StringCreator_stringcreator_stringcreator_
        {
            [Fact]
            public void _StringCreator_stringcreator_stringcreator_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\StringCreator\stringcreator\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"stringcreator.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"stringcreator.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\StringCreator\stringcreator\stringcreator.cmd");
                  

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
public class _THDChaos_thdchaos_thdchaos_
        {
            [Fact]
            public void _THDChaos_thdchaos_thdchaos_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\THDChaos\thdchaos\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdchaos.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdchaos.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\THDChaos\thdchaos\thdchaos.cmd");
                  

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
public class _THDList_thdlist_thdlist_
        {
            [Fact]
            public void _THDList_thdlist_thdlist_cmd()
            {
                int ret = -100;
                string outputFile = null;
                string errorFile = null;
                string testExecutable = null;
                Exception infraEx = null;

                try
                {
                  CoreclrTestWrapperLib wrapper = new CoreclrTestWrapperLib();
                  string testSubfolder = @"\GC.Scenarios\THDList\thdlist\";
                  outputFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdlist.output.txt");
                  errorFile = System.IO.Path.GetFullPath(_Global.reportBase + testSubfolder + @"thdlist.error.txt");
                  testExecutable = System.IO.Path.GetFullPath(_Global.testBinaryBase + @"\THDList\thdlist\thdlist.cmd");
                  

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
