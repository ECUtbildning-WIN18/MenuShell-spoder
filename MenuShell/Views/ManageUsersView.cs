using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class ManageUsersView: BaseView
    {
        private Dictionary<string, User> users;

        public ManageUsersView() : base("Manage Users")//tog bort dictionaryn users som inparameter (Dictionary<string, User> users)
        {
            //this.users = users;
        }

        private bool IsRunning = true;

        public void Display()
        {
            while (IsRunning)
            {
                Console.Clear();

                Console.WriteLine("1. Add user");// måste kunna lägga till via databasen
                Console.WriteLine("2. Search user");//Måste söka i databasen
                Console.WriteLine("Esc. Go back\n");
                Console.Write("> ");

                var key = ConsoleKey.NoName;

                while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                }

                if (key == ConsoleKey.D1)
                {
                    //AddUserView
                    var view = new AddUsersView();
                    var user = view.Display();
                }
                else if(key == ConsoleKey.D2)
                {
                    //SearchUserView
                    var searchusers = new SearchUserView();
                    var userSearchResult = searchusers.Display();

                    if(userSearchResult == null)
                    {
                        searchusers.Display();
                    }

                    //calls list users view
                    var listUsers = new ListUsersView(userSearchResult, users);
                    var searchresults = listUsers.Display();
                }

                if (key == ConsoleKey.Escape)
                {
                    IsRunning = false;
                }
            }
        }
    }
}
