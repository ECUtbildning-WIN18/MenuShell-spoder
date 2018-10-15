using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
