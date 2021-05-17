using Microsoft.AspNetCore.Mvc;

namespace MoqXunit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> SumTwoNumbers([FromQuery] int num1, 
                                          [FromQuery] int num2)
        {            
            return Ok(num1 + num2);
        }
    }
}