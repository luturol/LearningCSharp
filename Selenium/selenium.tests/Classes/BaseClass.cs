using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Selenium;

namespace selenium.tests.Classes
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
    }
}