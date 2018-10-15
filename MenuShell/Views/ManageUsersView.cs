using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class ManageUsersView: BaseView
    {
        public ManageUsersView(): base("Manage Users")
        {
         
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
                Console.WriteLine("Im going to add a user view here");
                Console.ReadKey();
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
