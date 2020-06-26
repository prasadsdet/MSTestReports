using AventStack.ExtentReports;
using CrossBrowserTesting.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossBrowserTesting
{
    [TestClass]
    public class TestSuite : TestBase
    {
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            reportLogger("UITEsts");
        }

        [TestInitialize]
        public void init()
        {
            Console.WriteLine(TestContext.TestName);
        }


        [TestMethod,TestCategory("ExtentTest")]
        public void TC1extentTestPASS()
        {
           // reportLogger(TestContext.TestName);
            parentTest = extent.CreateTest(TestContext.TestName);
            childTest = parentTest.CreateNode("Provide Parameter");
            childTest.Log(Status.Pass, "Test Passed1");
            int a = 100;
            int b = 200;
            int c = a + b;

        }

        [TestMethod, TestCategory("ExtentTest")]
        public void TC2extentTestFAIL()
        {
           // reportLogger(TestContext.TestName);
            parentTest = extent.CreateTest(TestContext.TestName);
            childTest = parentTest.CreateNode("Provide Parameter1");
            childTest.Log(Status.Fail, "Test Failed");
            int a = 100;
            int b = 200;
            int c = a + b;
        }


        [AssemblyCleanup]
        public static void Testclean()
        {
            extent.Flush();
        }
    }
}
