using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium
{
    public static class WebDriverExtensions
    {
        public static void OpenBrowserPage(this IWebDriver webDriver, TimeSpan timeToWait, string url)
        {
            webDriver.Manage().Timeouts().PageLoad = timeToWait;
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl(url);
        }

        public static string GetValue(this IWebDriver webDriver, By by)
        {
            IWebElement element = webDriver.FindElement(by);

            return element.Text;
        }

        public static void SetValue(this IWebDriver webDriver, By by, string value)
        {
            IWebElement element = webDriver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
        }

        public static void SubmitButton(this IWebDriver webDriver, By by)
        {
            IWebElement element = webDriver.FindElement(by);
            element.Submit();
        }

        public static void Wait(this IWebDriver webDriver, By by, TimeSpan timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, timeToWait);
            wait.Until(_ => _.FindElement(by) is not null);
        }
    }
}