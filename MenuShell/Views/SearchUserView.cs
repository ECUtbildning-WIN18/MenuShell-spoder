using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell.Views
{
    class SearchUserView : BaseView
    { 
        private Dictionary<string, User> users;

        private bool IsRunning = true;

        public SearchUserView(Dictionary<string, User> users) : base("Search user view")
        {
            this.users = users;
        }

        public List<User> Display()//returnera list med users ist för user eftersom det blir mer än en
        {
            Console.Clear();

            Console.WriteLine("Search by username: \n");
            Console.Write(">");
            var input = Console.ReadLine();

            Console.Clear();


            List<User> searchResult = new List<User>();

            foreach (var entry in users)
            {
                if (entry.Key.Contains(input))
                {
                    searchResult.Add(entry.Value);
                    //nu returnerar den all information om users som matchade resultatet. Kan ändra i list user sen till bara anv-namn.
                    IsRunning = false;
                }
            }

            if (searchResult.Count == 0)
            {
                Console.WriteLine("No users found matching the search term " + input);
                Thread.Sleep(2000);
            }

            return searchResult;// ska matas in i listUser view

        //searchResult.ForEach(Console.WriteLine);


            
        }
    }
}
