using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Specflow.PageObjects
{
    public class AuthenticationFormPage : PageObject
    {
        private readonly IWebDriver _driver;

        public AuthenticationFormPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void SetCredentials(string username, string password)
        {
            _textboxUsername.Clear();
            _textboxUsername.SendKeys(username);
            _textboxPassword.Clear();
            _textboxPassword.SendKeys(password);
        }

        public void CheckMessage(string expResult)
        {
            
        }

        public IWebElement _linkAuthenticationForm => _driver.FindElement(By.LinkText("Form Authentication"));

        public IWebElement _textboxUsername => _driver.FindElement(By.Id("username"));

        public IWebElement _textboxPassword => _driver.FindElement(By.Id("password"));

        public IWebElement _buttonLogin => _driver.FindElement(By.ClassName("radius"));

        public IWebElement _textMessage => _driver.FindElement(By.Id("flash"));
    }
}
