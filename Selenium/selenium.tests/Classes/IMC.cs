using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium;

namespace Selenium.Tests.Classes
{
    public class IMC
    {
        private IConfiguration configuration;
        private Browser browser;
        private IWebDriver webDriver;

        public IMC(IConfiguration configuration, Browser browser)
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
            string url = configuration.GetSection("Selenium:UrlAplicacao").Value;

            webDriver.OpenBrowserPage(TimeSpan.FromSeconds(5), url);            
        }

        public void ClosePage()
        {
            webDriver.Quit();
        }

        public void FillIMC(double weight, double height)
        {
            webDriver.SetValue(By.Id("id_Peso"), weight.ToString());            

            webDriver.SetValue(By.Name("Altura"), height.ToString());   
        }

        public void CalculateIMC()
        {
            webDriver.SubmitButton(By.Id("id_btnCalcular"));            

            webDriver.Wait(By.Id("ResultImc"), TimeSpan.FromSeconds(10));
        }

        public double GetIMC()
        {            
            return Convert.ToDouble(webDriver.GetValue(By.Id("ResultImc")));
        }

        public string GetMessage()
        {
            return webDriver.GetValue(By.ClassName("alert"));
        }
    }
}