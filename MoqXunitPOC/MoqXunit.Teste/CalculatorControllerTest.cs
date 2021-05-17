using System;
using Microsoft.AspNetCore.Mvc;
using MoqXunit.Controllers;
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
            CalculatorController controller = new CalculatorController();
            int expected = num1 + num2;

            //act
            var response = controller.SumTwoNumbers(num1, num2).Result as OkObjectResult;
            
            //assert
            Assert.NotNull(response);
            Assert.Equal(response.Value, expected);
        }

        [Fact]
        public void Sum_two_numbers_using_fact()
        {
            //arrange
            CalculatorController controller = new CalculatorController();
            int num1 = 1;
            int num2 = 2;
            int expected = num1 + num2;            

            //act
            var response = controller.SumTwoNumbers(num1, num2).Result as OkObjectResult;
            
            //assert
            Assert.NotNull(response);
            Assert.Equal(response.Value, expected);
        }
    }
}
