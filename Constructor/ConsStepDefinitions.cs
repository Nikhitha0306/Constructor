using System;
using TechTalk.SpecFlow;

namespace Constructor
{
    [Binding]
    public class ConsStepDefinitions
    {
        [Given(@"I am on the rahul shetty academy")]
        public void GivenIAmOnTheRahulShettyAcademy()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the login")]
        public void WhenIClickOnTheLogin()
        {
            throw new PendingStepException();
        }

        [Then(@"I need to enter the webpage successfully")]
        public void ThenINeedToEnterTheWebpageSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
