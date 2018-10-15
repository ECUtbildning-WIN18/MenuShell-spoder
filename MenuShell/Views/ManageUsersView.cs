using System;
using System.Collections.Generic;
using System.Text;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class ManageUsersView: BaseView
    {
        private Dictionary<string, User> users;

        public ManageUsersView(Dictionary<string, User> users) : base("Manage Users")
        {
            this.users = users;
        }

        public void Display()
        {
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Delete user \n");
            Console.Write("> ");

            var key = ConsoleKey.NoName;

            while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
            {
                key = Console.ReadKey(true).Key;
            }

            if (key == ConsoleKey.D1)
            {
                //AddUserView
                var view = new AddUsersView();
                var user = view.Display();  
                users.Add(user.UserName, user);
            }
            else
            {
                //DeleteUserView
                Console.WriteLine("Im going to add Delete user view here");
                Console.ReadKey();
            }

        }
    }
}
