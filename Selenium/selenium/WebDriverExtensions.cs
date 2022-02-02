using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium
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

        public static void Wait(this IWebDriver webDriver, By by, TimeSpan timeToWait = default(TimeSpan))
        {
            if(timeToWait == default(TimeSpan))
            {
                timeToWait = TimeSpan.FromSeconds(5);
            }

            SleepTest();

            WebDriverWait wait = new WebDriverWait(webDriver, timeToWait);
            wait.Until(_ => _.FindElement(by));
        }

        public static void ClickButton(this IWebDriver webDriver, By by)
        {
            IWebElement button = webDriver.FindElement(by);
            button.Click();
        }

        public static void SleepTest(int millisecondsTimeOut = 500)
        {
            Thread.Sleep(millisecondsTimeOut);
        }
    }
}