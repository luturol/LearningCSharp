using System.Collections.Generic;
using System.Linq;
using JwtPOC.Models;

namespace JwtPOC.Repositories
{
    public class UserRepository
    {
        public User GetUser(User user)
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Username = "Naruto", Password = "hokage", Role = "genin" },
                new User { Id = 2, Username = "Sasuke", Password = "itachi", Role = "genin" },
                new User { Id = 2, Username = "Kakashi", Password = "hbooks", Role = "jonin" }
            };

            return users.FirstOrDefault(e => e.Username.ToLower() == user.Username.ToLower() && e.Password.ToLower() == user.Password.ToLower());
        }
    }
}