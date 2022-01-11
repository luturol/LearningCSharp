using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Selenium;

namespace ContatosTestes.classesBase
{
    public class BaseClass
    {
        public IConfiguration configuration;
        private Browser browser;
        public IWebDriver webDriver;

        public BaseClass(IConfiguration configuration, Browser browser)
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

        public void CarregarPagina()
        {
            webDriver.OpenBrowserPage(TimeSpan.FromSeconds(5), configuration.GetSection("Selenium:UrlAplicacao").Value);
        }

        public void FecharPagina()
        {
            webDriver.Quit();
            webDriver = null;
        }
    }
}