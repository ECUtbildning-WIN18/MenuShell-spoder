using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class AddUsersView : BaseView
    {
        public AddUsersView() : base("Add user view")
        {
                
        }

        private bool IsRunning = true;
        //här är user vad den ska returnera
        public User Display()
        {
            while (IsRunning)
            {
                Console.Clear();

                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                Console.Write("Role: ");
                var roleInput = Console.ReadLine();
                roleInput = roleInput.ToLower();

                Console.WriteLine("Is this correct? (Y)es, (N)o");
                ConsoleKey key = ConsoleKey.NoName;

                while (key != ConsoleKey.Y && key != ConsoleKey.N && key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                }
                
                if (key == ConsoleKey.Y)
                {
                    var role = Role.Undefined;
                    switch (roleInput)
                    {
                        case "administrator":
                            role = Role.Administrator;
                            break;
                        case "receptionist":
                            role = Role.Receptionist;
                            break;
                        case "veterinarian":
                            role = Role.Veterinarian;
                            break;
                    }

                    if (key == ConsoleKey.Escape)
                    {
                        IsRunning = false;
                    }

                    Console.Clear();
                    var user = new User(username, password, role);
                    Console.WriteLine("User added!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    IsRunning = false;
                    return user;
                }
            }
            return null;
        } 
    }
}
