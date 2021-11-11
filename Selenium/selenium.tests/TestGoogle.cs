using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using selenium;

namespace Selenium.Tests
{
    public class TestGoogle
    {
        private IConfiguration configuration;
        private Browser browser;
        private IWebDriver webDriver;


        public TestGoogle(IConfiguration configuration, Browser browser)
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
    }
}