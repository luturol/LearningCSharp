using JwtPOC.Interfaces;
using JwtPOC.Models;
using JwtPOC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JwtPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private ITokenService tokenService;
        public AuthenticationController(ITokenService token)
        {
            tokenService = token;
        }

        [HttpPost("login")]
        public ActionResult GetUser(User user)
        {
            var loged = new UserRepository().GetUser(user);

            if (loged == null)
                return Forbid();

            var token = tokenService.GenerateToken(loged);

            return Ok(new { loged, token });
        }
    }
}