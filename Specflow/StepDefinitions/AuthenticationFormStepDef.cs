using System;
using OpenQA.Selenium;
using Specflow.PageObjects;
using TechTalk.SpecFlow;

namespace Specflow.StepDefinitions
{
    [Binding]
    public class AuthenticationFormStepDef
    {
        private readonly AuthenticationFormPage _page;

        public AuthenticationFormStepDef(IWebDriver driver)
        {
            _page = new AuthenticationFormPage(driver);
        }

        [Given(@"user lands on The Internet Herokuapp application")]
        public void GivenUserLandsOnTheInternetHerokuappApplication()
        {
            _page.Navigate("https://the-internet.herokuapp.com");
        }

        [Given(@"user opens the ""(.*)"" page")]
        public void GivenUserOpensThePage(String arg0)
        {
            _page._linkAuthenticationForm.Click();

        }

        [When(@"I type ""(.*)"" and ""(.*)""")]
        public void WhenITypeUsernameAndPassword(String arg0, String arg1)
        {
            _page.SetCredentials(arg0, arg1);
        }


        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            _page._buttonLogin.Submit();

        }


        [Then(@"the ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(String arg0)
        {

        }
    }

}
