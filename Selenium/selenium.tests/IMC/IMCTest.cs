using System.IO;
using Microsoft.Extensions.Configuration;
using selenium.tests.Classes;
using Selenium;
using Selenium.Tests.Classes;
using Xunit;

namespace selenium.tests
{
    public class IMCTest : BaseTest
    {        
        public IMCTest() : base()
        {            
        }

        private void ExecutaIMC(Browser browser, double weight,
            double height, double expectedResult,
            string expectedMessage)
        {
            IMC imc = new IMC(configuration, browser);
            imc.LoadPage();
            imc.FillIMC(weight, height);
            imc.CalculateIMC();

            var actualResult = imc.GetIMC();
            var actualMessage = imc.GetMessage();

            imc.ClosePage();

            Assert.NotNull(actualResult);
            Assert.Equal(expectedResult, actualResult);
            Assert.NotEmpty(actualMessage);
            Assert.Equal(expectedMessage, actualMessage);
            Assert.True(actualMessage.Contains(expectedMessage));
        }

        [Fact]
        public void TestIMC()
        {
            ExecutaIMC(Browser.Chrome, 50, 1.75, 16.33, "Muito abaixo do peso");
        }

        [Fact]
        public void TestFireFox()
        {
            ExecutaIMC(Browser.Firefox, 85, 1.74, 28.08, "Acima do Peso");
        }
    }
}