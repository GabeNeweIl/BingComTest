using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingComTests.Chrome.Steps
{
    [Binding]
    public class ChromeFeaturesLoginSteps
    {
        Data data = new Data();

        [Given(@"Webpage bing\.com")]
        public void GivenWebpageBing_Com()
        {
            Hooks.driver.Navigate().GoToUrl("https://www.bing.com/");
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            Thread.Sleep(1500);
            WaitMethods.Wait(Hooks.driver, data._signinLink, 3000);
            var signinLink = Hooks.driver.FindElement(data._signinLink);
            signinLink.Click();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            WaitMethods.Wait(Hooks.driver, data._emailField, 2000);
            dynamic loginData = table.CreateDynamicInstance();
            var emailField = Hooks.driver.FindElement(data._emailField);
            emailField.SendKeys((string)loginData.Email);

            var loginButton = Hooks.driver.FindElement(data._loginButton);
            loginButton.Click();

            WaitMethods.Wait(Hooks.driver, data._passwordField, 2000);
            var passwordField = Hooks.driver.FindElement(data._passwordField);
            passwordField.SendKeys((string)loginData.Password);
        }

        [Given(@"i click login button")]
        public void GivenIClickLoginButton()
        {
            var loginButton = Hooks.driver.FindElement(data._loginButton);
            loginButton.Click();
        }

        [Then(@"I should see UserName 'Сойка'")]
        public void ThenIShouldSeeUserName()
        {
            WaitMethods.Wait(Hooks.driver, data._logoutLink, 2000);
            var expectedUserName = Hooks.driver.FindElement(data._logoutLink);
            Assert.AreEqual("Сойка", expectedUserName.Text);
        }
    }
}
