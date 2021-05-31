using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoqXunit.Interfaces;
using MoqXunit.Models;

namespace MoqXunit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private ICalculatorRepository _repository;

        public CalculatorController(ICalculatorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult SumTwoNumbers([FromQuery] int num1,
                                          [FromQuery] int num2)
        {

            var allCalculations = _repository.GetAllCalculations();
            if (allCalculations.Any(e => e.Value1 == num1 && e.Value2 == num2))
            {
                return Ok(allCalculations.First(e => e.Value1 == num1 && e.Value2 == num2));
            }
            else
            {
                var calculation = new Calculation
                {
                    Value1 = num1,
                    Value2 = num2,
                    Result = num1 + num2
                };

                _repository.SaveCalculation(calculation);

                return Ok(calculation);
            }
        }

        public virtual int SubstractTwoNumbers(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}