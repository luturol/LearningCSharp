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
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            webDriver.Navigate().GoToUrl(configuration.GetSection("Selenium:UrlAplicacao").Value);
        }

        public void ClosePage()
        {
            webDriver.Quit();
        }

        public void FillIMC(double weight, double height)
        {
            IWebElement elementWeight = webDriver.FindElement(By.Id("id_Peso"));
            elementWeight.SendKeys(weight.ToString());

            IWebElement elementHeight = webDriver.FindElement(By.Name("Altura"));
            elementHeight.SendKeys(height.ToString());
        }

        public void CalculateIMC()
        {
            IWebElement buttonCalculate = webDriver.FindElement(By.Id("id_btnCalcular"));
            buttonCalculate.Submit();

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.Id("ResultImc")) != null);
        }

        public double GetIMC()
        {
            IWebElement resultImc = webDriver.FindElement(By.Id("ResultImc"));
            return Convert.ToDouble(resultImc.Text);
        }

        public string GetMessage()
        {
            IWebElement message = webDriver.FindElement(By.ClassName("alert"));

            return message.Text;
        }
    }
}