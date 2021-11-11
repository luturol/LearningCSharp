using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Selenium;

namespace selenium
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver = null)
        {
            IWebDriver webDriver = null;

            switch(browser)
            {
                case Browser.Chrome:
                    webDriver = new ChromeDriver(pathDriver);

                    break;
                case Browser.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(pathDriver);
                    webDriver = new FirefoxDriver(service);
                    
                    break;
            }

            return webDriver;
        }
    }
}