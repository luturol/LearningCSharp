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

            webDriver = Driver.GetNewInstance(configuration, browser);
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