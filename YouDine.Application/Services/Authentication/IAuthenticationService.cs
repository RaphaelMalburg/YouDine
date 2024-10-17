using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouDine.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Login(string firstName, string lastName, string email, string password);
        AuthenticationResult Register( string email, string password);
    }
}
