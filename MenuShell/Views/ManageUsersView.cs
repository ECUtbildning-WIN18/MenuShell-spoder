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

        private bool IsRunning = true;

        public void Display()
        {
            while (IsRunning)
            {
                Console.Clear();

                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Search user");
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
                    users.Add(user.UserName, user);
                }
                else if(key == ConsoleKey.D2)
                {
                    //SearchUserView
                    var searchusers = new SearchUserView(users);
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
