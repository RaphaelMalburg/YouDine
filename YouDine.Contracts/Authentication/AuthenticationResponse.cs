using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouDine.Contracts.Authentication
{
    public record AuthenticationResponse
    (
        Guid id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}
