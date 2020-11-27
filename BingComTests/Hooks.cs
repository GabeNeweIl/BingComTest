using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BingComTests
{
    [Binding]
    public sealed class Hooks 
    {
        public static IWebDriver driver;

        [AfterTestRun]
        public static void QuitBrowser()
        {
            driver.Quit();
        }

        [BeforeFeature("Chrome")]
        public static void StartChrome()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [AfterFeature("Chrome")]
        public static void CloseChrome()
        {
            driver.Quit();
        }

        [BeforeFeature("Firefox")]
        public static void StartFirefox()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();

            driver.Manage().Window.Maximize();
        }

        [AfterFeature("Firefox")]
        public static void CloseFirefox()
        {
            driver.Quit();
        }
    }
}
