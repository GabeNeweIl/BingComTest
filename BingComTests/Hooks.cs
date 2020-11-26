using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BingComTests
{
    [Binding]
    public sealed class Hooks 
    {
        public static IWebDriver driver;
        [BeforeFeature("CFLocalization")]
        public static void StartingChrome()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [BeforeFeature("FFLocalization")]
        public static void StartingFirefox()
        {
            if (driver != null)
                driver.Quit();
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driver.Manage().Window.Maximize();
        }
        [AfterTestRun]
        public static void QuitBrowser()
        {
            driver.Quit();
        }
    }
}
