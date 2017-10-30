using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public sealed class Google_OAuth
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"a valid google user is logged in")]
        public void GivenAValidGoogleUserIsLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"he requested task ""(.*)"" creation under taskList ""(.*)""")]
        public void WhenHeRequestedTaskCreationUnderTaskList(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the task should be created")]
        public void ThenTheTaskShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"he requested to move the task ""(.*)"" under taskList ""(.*)""")]
        public void WhenHeRequestedToMoveTheTaskUnderTaskList(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the task should be moved")]
        public void ThenTheTaskShouldBeMoved()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
