using System;
using StationarySystem;
using TechTalk.SpecFlow;

namespace Testing
{
    [Binding]
    public class LoginSteps
    {
        private User user = new User();
        [Given(@"I have an account in the system")]
        public void GivenIHaveAnAccountInTheSystem(int userID)
        {
            userID = 4;
            
        }
        
        [Given(@"I have also entered the correct details")]
        public void GivenIHaveAlsoEnteredTheCorrectDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system should take me to the home screen")]
        public void ThenTheSystemShouldTakeMeToTheHomeScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
