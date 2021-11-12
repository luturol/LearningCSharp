using System.IO;
using Microsoft.Extensions.Configuration;
using Selenium;
using Selenium.Tests.Classes;
using Xunit;

namespace selenium.tests
{
    public class IMCTest
    {
        private IConfiguration configuration;

        public IMCTest()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }

        private void ExecutaIMC(Browser browser)
        {
            IMC imc = new IMC(configuration, browser);
            imc.LoadPage();

            imc.ClosePage();
        }

        [Fact]
        public void TestIMC()
        {
            ExecutaIMC(Browser.Chrome);
        }
    }
}