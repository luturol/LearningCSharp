using System;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using selenium;
using selenium.tests.Classes;

namespace Selenium.Tests.Classes
{
    public class Google : BaseClass
    {
        public Google(IConfiguration configuration, Browser browser) : base(configuration, browser)
        {            
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