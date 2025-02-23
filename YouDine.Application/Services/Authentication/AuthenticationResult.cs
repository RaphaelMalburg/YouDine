using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouDine.Application.Services.Authentication
{
    public record AuthenticationResult
    (
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}
