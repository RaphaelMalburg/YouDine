using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouDine.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string firstName, string lastName, string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "token");
        }

        public AuthenticationResult Register(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        }
    }
}
