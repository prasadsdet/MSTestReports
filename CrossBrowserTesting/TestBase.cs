using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossBrowserTesting.Properties
{
    public class TestBase 
    {

        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReportr;       
        public static ExtentTest parentTest;
        public static ExtentTest childTest;
        public static string dirpath;

        public  static void reportLogger(string testCaseName)
        {
            extent = new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            Directory.CreateDirectory(dir + "\\TetsExecutionReports\\");
            Random rand = new Random();
            string randdomno = rand.Next(1000).ToString();
            dirpath = dir + "\\TestExecutionReports\\Test_Execution_Reports" + "_" + testCaseName;
            htmlReportr = new ExtentHtmlReporter(dirpath);
            htmlReportr.Config.Theme = Theme.Dark;
            extent.AttachReporter(htmlReportr);
            extent.AddSystemInfo("Host Name", System.Net.Dns.GetHostName());
            extent.AddSystemInfo("User Name", "Prasad.Nunna");

        }
    }
}
