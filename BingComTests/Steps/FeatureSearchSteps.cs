using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace BingComTests.Chrome.Steps
{
    [Binding]
    public class ChromeFeatureSearchSteps
    {
        Data data = new Data();

        [Given(@"I enter the following text")]
        public void GivenIEnterTheFollowingText(Table table)
        {
            Hooks.driver.Navigate().GoToUrl("https://www.bing.com/");

            WaitMethods.Wait(Hooks.driver, data._searchFrom, 1500);

            var serachForm = Hooks.driver.FindElement(data._searchFrom);

            serachForm.SendKeys("star wars episode vi");
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            WaitMethods.Wait(Hooks.driver, data._searchButton, 1000);

            var searchButton = Hooks.driver.FindElement(data._searchButton);

            searchButton.Click();
        }

        [Then(@"Title of page must be '(.*)'")]
        public void ThenTitleOfPageMustBe(string p0)
        {
            Thread.Sleep(1500);

            string actualTitle = Hooks.driver.Title;

            string expectedTitle = "star wars episode vi - Bing";

            Assert.AreEqual(expectedTitle, actualTitle, $"Not equal! Actual title are {actualTitle}.");
        }

        [Then(@"The number of related searches should be (.*)")]
        public void ThenTheNumberOfRelatedSearchesShouldBe(int p0)
        {
            WaitMethods.Wait(Hooks.driver, data._relatedSearchList, 5000);

            var element = Hooks.driver.FindElement(data._relatedSearchList);

            var list = element.FindElements(By.TagName("li"));

            int actualCount = list.Count;

            int expectedCount = 8;

            Assert.AreEqual(expectedCount, actualCount, $"Not equal! The number of related searches equals {actualCount}.");
        }
        [Then(@"The number of search result should be (.*)")]
        public void ThenTheNumberOfSearchResultShouldBe(int p0)
        {
            Thread.Sleep(3000);

            WaitMethods.Wait(Hooks.driver, data._searchListResult,5000);

            var element = Hooks.driver.FindElement(data._searchListResult);

            var list = element.FindElements(data._searchResult);

            int actualCount = list.Count;

            int expectedCount = 9;

            Assert.AreEqual(expectedCount, actualCount, $"Not equal! The number of searches results equals {actualCount}.");
        }
    }
}
