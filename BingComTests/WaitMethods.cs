using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BingComTests
{
    public static class WaitMethods
    {
        public static void Wait(IWebDriver driver, By locator, int waitTime)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(waitTime));

                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (Exception)
            {
                throw new Exception(string.Format("Web element was not found"));
            }
        }
    }
}
