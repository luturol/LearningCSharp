using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MoqXunit.Controllers;
using MoqXunit.Interfaces;
using MoqXunit.Models;
using Xunit;

namespace MoqXunit.Teste
{
    public class CalculatorControllerTest
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 5)]
        [InlineData(1, 6)]
        [InlineData(10, 2)]
        [InlineData(1999, 2)]
        public void Sum_Two_Numbers_using_theory(int num1, int num2)
        {
            //arrange
            var mock = new Mock<ICalculatorRepository>();
            mock.Setup(e => e.GetAllCalculations()).Returns(Enumerable.Empty<Calculation>());
            mock.Setup(e => e.SaveCalculation(It.IsAny<Calculation>()));
            var controller = new CalculatorController(mock.Object);
            int expected = num1 + num2;

            //act
            var response = controller.SumTwoNumbers(num1, num2) as OkObjectResult;

            //assert
            Assert.NotNull(response);
            Assert.Equal(response.Value, expected);
        }

        [Fact]
        public void Sum_two_numbers_using_fact()
        {
            //arrange
            var mock = new Mock<ICalculatorRepository>();
            mock.Setup(e => e.GetAllCalculations()).Returns(Enumerable.Empty<Calculation>());
            mock.Setup(e => e.SaveCalculation(It.IsAny<Calculation>()));
            var controller = new CalculatorController(mock.Object);

            int num1 = 1;
            int num2 = 2;
            int expected = num1 + num2;

            //act
            var response = controller.SumTwoNumbers(num1, num2) as OkObjectResult;

            //assert
            Assert.NotNull(response);
            Assert.Equal(response.Value, expected);
        }        
    }
}
