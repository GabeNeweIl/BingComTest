using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace BingComTests.Chrome.Steps
{
    [Binding]
    public class ChromeFeaturesLogoutSteps
    {
        Data data = new Data();

        [Given(@"I Click logout link")]
        public void GivenIClickLogoutLink()
        {
            Thread.Sleep(2000);

            var logoutLink = Hooks.driver.FindElement(data._logoutLink);

            logoutLink.Click();
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            Thread.Sleep(1500);

            var logoutButton = Hooks.driver.FindElement(data._logoutButton);

            logoutButton.Click();
        }

        [Then(@"We should get the login link")]
        public void ThenWeShouldGetTheLoginLink()
        {
            Thread.Sleep(1500);

            var loginLink = Hooks.driver.FindElement(data._signinLink).Displayed;

            Assert.IsTrue(loginLink);
        }
    }
}
