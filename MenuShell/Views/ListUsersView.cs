using MenuShell.Domain;
using System;
using System.Collections.Generic;

namespace MenuShell.Views
{
    class ListUsersView : BaseView       //den här ska ta in "searchResult" från "search user view".
    {
        private Dictionary<string, User> Users;

        private List<User> SearchResult;

        private bool IsRunning = true;


        public ListUsersView(List<User> searchResult, Dictionary<string, User> users) : base("List users view")
        {
            SearchResult = searchResult;
            Users = users;
        }


        public List<User> Display()
        {
          
                foreach (var result in SearchResult)
                {
                    Console.WriteLine(result.UserName);
                }

            Console.WriteLine("(D)elete?\n");

            while (IsRunning)
            { 
                Console.WriteLine("Press Escape to go back.");
                ConsoleKey key = ConsoleKey.NoName;
   

                while (key != ConsoleKey.D && key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                }

                if (key == ConsoleKey.D)
                {
                    var deleteUserView = new DeleteUsersView(SearchResult);
                    deleteUserView.Display();
                }
                
                else if(key == ConsoleKey.Escape)
                {
                    SearchResult = null;
                    break;
                }
            }
            return null;
        }


    }
}
