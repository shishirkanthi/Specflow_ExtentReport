using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extent_Specflow
{
    public class ReportHelper
    {
        private ReportHelper() { }

        private static ExtentReports extentReport=null;
        private static ExtentTest extentTest = null;

        public static ExtentReports Init()
        {
            if (extentReport == null)
            {
                extentReport = new ExtentReports();
                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Logs\Report.html");
                extentReport.AttachReporter(htmlReporter);
            }
            return extentReport;
        }

        public static ExtentReports Report
        {
            get
            {
                if (extentReport == null)
                {
                    extentReport = new ExtentReports();
                    ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Report.html");
                    extentReport.AttachReporter(htmlReporter);
                }
                return extentReport;
            }
        }

        public static ExtentTest InitLogger(string scenarioName)
        {
            extentTest = extentReport.CreateTest(scenarioName);
            return extentTest;
        }

        public static ExtentTest Log
        {
            get
            {                
                return extentTest;
            }
        }

        public static void WriteReport()
        {
            extentReport.Flush();
        }
    }
}
