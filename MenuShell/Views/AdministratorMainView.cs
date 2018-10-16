using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class AdministratorMainView : BaseView
    {
        private Dictionary<string, User> users;

        public AdministratorMainView(Dictionary<string, User> users) : base("Administrator Main View")
        {
            this.users = users;
        }

        public bool Display()
        {
            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Exit \n");
            Console.Write("> ");

            var key = ConsoleKey.NoName;

            while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true).Key;
            }

            if (key == ConsoleKey.D2)
            {
                return false;
            }
            else
            {//måste vara samma dictionary, inte en ny (this.users)
                var view = new ManageUsersView(users);
                view.Display();
            }

            return true;
        }
    }
}
