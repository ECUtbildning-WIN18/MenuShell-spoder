using System;
using System.Collections.Generic;
using MenuShell.Domain;
using MenuShell.Services;
using MenuShell.Views;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, User>
            {
                {"admin", new User("admin", "admin", Role.Administrator)}
            };

            var authenticate = new AuthenticationService(users);
            var loginView = new LoginView(authenticate);

            bool isRunning = true;
            while (isRunning)
            {
                var validUser = loginView.Display();


                switch (validUser.Role)
                {
                    case Role.Administrator:
                    {
                        var View = new AdministratorMainView(users);
                        View.Display();
                        break;
                    }
                    case Role.Receptionist:
                    {
                        break;
                    }
                    case Role.Veterinarian:
                    {
                        var VetView = new VeterinarianMainView();
                        VetView.Display();
                        break;
                    }
                }
            }
        }
    }
}
