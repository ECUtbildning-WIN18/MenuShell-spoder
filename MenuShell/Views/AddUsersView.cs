using System;
using System.Collections.Generic;
using System.Text;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class AddUsersView : BaseView
    {
        public AddUsersView() : base("Add user view")
        {
                
        }
        //här är user vad den ska returnera
        public User Display()
        {
            do
            {
                Console.Clear();

                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                Console.Write("Role: ");
                var roleInput = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es, (N)o");
                ConsoleKey key = ConsoleKey.NoName;

                while (key != ConsoleKey.Y && key != ConsoleKey.N)
                {
                    key = Console.ReadKey(true).Key;
                }
                
                if (key == ConsoleKey.Y)
                {
                    var role = Role.Undefined;
                    switch (roleInput)
                    {
                        case "Administrator":
                            role = Role.Administrator;
                            break;
                        //ska lägga till de andra rollerna till switchen
                    }
                    var user = new User(username, password, role);
                    return user;
                }
            } while (true);
        }
    }
}
