using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver = null)
        {
            IWebDriver webDriver = null;

            switch(browser)
            {
                case Browser.Chrome:
                    ChromeOptions optionsChrome = new ChromeOptions();
                    optionsChrome.AcceptInsecureCertificates = true;                    
                    
                    webDriver = new ChromeDriver(pathDriver, optionsChrome);

                    break;
                case Browser.Firefox:
                    //Solucao para resolver problema de certificado no Firefox com https
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AcceptInsecureCertificates = true;

                    //Nao funciona com pagina https sem certificado
                    // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(pathDriver);

                    webDriver = new FirefoxDriver(pathDriver, firefoxOptions);
                    
                    break;
            }

            return webDriver;
        }
    }
}