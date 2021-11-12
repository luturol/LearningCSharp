using System;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using selenium;

namespace Selenium.Tests.Classes
{
    public class Google
    {
        private IConfiguration configuration;
        private Browser browser;
        private IWebDriver webDriver;


        public Google(IConfiguration configuration, Browser browser)
        {
            this.configuration = configuration;
            this.browser = browser;

            string pathDriver = string.Empty;

            if (browser == Browser.Firefox)
            {
                pathDriver = configuration.GetSection("Selenium:PathDriverFirefox").Value;
            }
            else if (browser == Browser.Chrome)
            {
                pathDriver = configuration.GetSection("Selenium:PathDriverChrome").Value;
            }

            webDriver = WebDriverFactory.CreateWebDriver(this.browser, pathDriver);
        }

        public void LoadPage()
        {
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            webDriver.Navigate().GoToUrl("http://www.google.com.br");
        }

        public void ClosePage()
        {
            webDriver.Quit();
        }

        public ReadOnlyCollection<IWebElement> Search(string content)
        {
            IWebElement webElement = webDriver.FindElement(By.Name("q"));
            webElement.SendKeys(content);
            webElement.SendKeys(Keys.Enter);
            
            Thread.Sleep(5000);
            
            IWebElement resultSearch = webDriver.FindElement(By.Id("search"));
            var results = resultSearch.FindElements(By.XPath(".//a"));
            
            return results;
        }
    }
}