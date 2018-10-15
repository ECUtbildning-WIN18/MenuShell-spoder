using MenuShell.Domain;
using MenuShell.Services;
using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Services
{
    class AuthenticationService : IAuthenticationService
    {
        private Dictionary<string, User> users;

        public AuthenticationService(Dictionary<string, User> users)
        {
            this.users = users;
        }


        public User Authenticate(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].PassWord == password)
            {
                return users[username];
            }
            else
            {
                return null;
            }
        }

    }
}
