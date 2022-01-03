using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using selenium;
using selenium.tests.Classes;

namespace Selenium.Tests.Classes
{
    public class IMC : BaseClass
    {
        public IMC(IConfiguration configuration, Browser browser) : base(configuration, browser)
        {           
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