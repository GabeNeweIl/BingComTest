using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BingComTests.Chrome.Steps
{
    [Binding]
    public class ChromeFeatureLanguageSteps
    {
        Data data = new Data();
        [Given(@"I click menu bar link")]
        public void GivenIClickMenuBarLink()
        {
            Thread.Sleep(2000);
            WaitMethods.Wait(Hooks.driver, data._menubarLink, 2000);
            var menubarLink = Hooks.driver.FindElement(data._menubarLink);
            menubarLink.Click();
        }
        
        [Given(@"I click settings link")]
        public void GivenIClickSettingsLink()
        {
            WaitMethods.Wait(Hooks.driver, data._settingLink, 1000);
            var settingLink = Hooks.driver.FindElement(data._settingLink);
            settingLink.Click();
        }
        
        [Given(@"I click language link")]
        public void GivenIClickLanguageLink()
        {
            WaitMethods.Wait(Hooks.driver, data._languageLink, 1000);
            var languageLink = Hooks.driver.FindElement(data._languageLink);
            languageLink.Click();
        }
        
        [When(@"I click on link of english localization")]
        public void WhenIClickOnLinkOfEnglishLocalization()
        {
            WaitMethods.Wait(Hooks.driver, data._englishLanguage, 2000);
            var englishLanguageLink = Hooks.driver.FindElement(data._englishLanguage);
            englishLanguageLink.Click();
        }
        
        [Then(@"Images link should be '(.*)'")]
        public void ThenImagesLinkShouldBe(string p0)
        {
            var imagesText = Hooks.driver.FindElement(data._imagesLink);
            string expectedText = "Images";
            Assert.AreEqual(expectedText, imagesText.Text, $"Not equal! Actual text {imagesText.Text}");
        }
    }
}
