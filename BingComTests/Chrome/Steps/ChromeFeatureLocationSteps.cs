using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BingComTests.Chrome.Steps
{
    [Binding]
    public class ChromeFeatureLocationSteps
    {
        Data data = new Data();
        [Given(@"I click location link")]
        public void GivenIClickLocationLink()
        {
            Thread.Sleep(2000);
            WaitMethods.Wait(Hooks.driver, data._locationLink,2000);
            var locationLink = Hooks.driver.FindElement(data._locationLink);
            locationLink.Click();
            Thread.Sleep(1000);
        }
        
        [When(@"I click on link to change location")]
        public void WhenIClickOnLinkToChangeLocation()
        {
            WaitMethods.Wait(Hooks.driver, data._USALocationLink, 3000);
            var USALocationLink = Hooks.driver.FindElement(data._USALocationLink);
            USALocationLink.Click();
        }

        [Then(@"I should see carousel with trends")]
        public void ThenIShouldSeeCarouselWithTrends()
        {
            WaitMethods.Wait(Hooks.driver, data._crsTrends, 3000);
            var crsTrends = Hooks.driver.FindElement(data._crsTrends).Displayed;
            Assert.IsTrue(crsTrends, $"Carousel with trends is not displayed!");
        }
    }
}
