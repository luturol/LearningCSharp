using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Selenium;

namespace ContatosTestes.classesBase
{
    public static class Driver
    {
        private static IWebDriver _instance { get; set; }

        public static IWebDriver GetNewInstance(IConfiguration configuration, Browser browser)
        {
            string pathDriver = string.Empty;

            if (browser == Browser.Firefox)
            {
                pathDriver = configuration.GetSection("Selenium:PathDriverFirefox").Value;
            }
            else if (browser == Browser.Chrome)
            {
                pathDriver = configuration.GetSection("Selenium:PathDriverChrome").Value;
            }

            _instance = WebDriverFactory.CreateWebDriver(browser, pathDriver);

            return _instance;
        }

        public static IWebDriver GetInstance()
        {
            return _instance;
        }

        public static void FecharPagina()
        {
            _instance.Quit();
        }
    }
}