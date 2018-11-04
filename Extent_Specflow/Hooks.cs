using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Extent_Specflow
{
    [Binding]
    class Hooks
    {
        [BeforeTestRun]
        public static void ExecutionSetup()
        {
            ReportHelper.Init();
        }

        [BeforeScenario]
        public static void ScenarioSetup()
        {
            ReportHelper.InitLogger(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public static void ScenarioCleanup()
        {
            ReportHelper.Log.Pass("Etent reporting pass");
            ReportHelper.WriteReport();
        }
    }
}
