using MenuShell.Domain;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Services;

namespace MenuShell.Views
{
    //loginview ska bara ta input av användaren och kolla om användaren finns.
    class LoginView : BaseView
    {
        public AuthenticationService AuthenticationService { get; }

        public LoginView(AuthenticationService authenticate) : base("Login View")
        {
            AuthenticationService = authenticate;
        }

        public User Display()
        {
            User user = null;

            do
            {
                Console.Clear();
                Console.WriteLine("# Login user\n");
                Console.WriteLine("Username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Password: ");
                var password = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es, (N)o");
                ConsoleKey key = ConsoleKey.NoName;

                while (key != ConsoleKey.Y && key != ConsoleKey.N)
                {
                    key = Console.ReadKey(true).Key;
                }

                if (key == ConsoleKey.Y)
                {
                    user = AuthenticationService.Authenticate(username, password);
                    if (user == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid login! Try again.");
                        Thread.Sleep(2000);
                    }
                }

            } while (user == null);

            return user;

        }




    }
}
