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
        public AdministratorMainView() : base("Administrator Main View")
        {
            
        }

        public bool Display()
        {
            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Exit \n");
            Console.Write("> ");

            var key = ConsoleKey.NoName;

            while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
            {
                key = Console.ReadKey(true).Key;
            }

            if (key == ConsoleKey.D2)
            {
                return false;
            }
            else
            {
                var view = new ManageUsersView();
                view.Display();
            }

            return true;
        }
    }
}
