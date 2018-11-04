using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class AdministratorMainView : BaseView
    {
        private List< User> users;

        public AdministratorMainView() : base("Administrator Main View")//tog bort dictionaryn users som inparameter (Dictionary<string, User> users)
        {
            //this.users = users;
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
                var view = new ManageUsersView();// tog bort dictionaryn users som inparameter
                view.Display();
            }

            return true;
        }
    }
}
