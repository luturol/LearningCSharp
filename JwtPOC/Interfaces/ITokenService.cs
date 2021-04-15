using JwtPOC.Models;

namespace JwtPOC.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}