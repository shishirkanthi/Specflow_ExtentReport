using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Extent_Specflow
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"There is an user wanting to do some activity")]
        public void GivenThereIsAnUserWantingToDoSomeActivity()
        {
            //Code for some pre-req tasks for user
            ReportHelper.Log.Info($"Some log from step1 for scenario: {ScenarioContext.Current.ScenarioInfo.Title}");
        }

        [When(@"User performs action related to that activity")]
        public void WhenUserPerformsActionRelatedToThatActivity()
        {
            ReportHelper.Log.Info($"Some log from step2 for scenario: {ScenarioContext.Current.ScenarioInfo.Title}");
        }

        [Then(@"He should be able to see the result")]
        public void ThenHeShouldBeAbleToSeeTheResult()
        {
            ReportHelper.Log.Info("Some log from step3 for scenario: {ScenarioContext.Current.ScenarioInfo.Title}");
        }


    }
}
