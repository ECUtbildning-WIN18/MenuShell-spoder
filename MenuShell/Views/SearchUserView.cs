using MenuShell.Domain;
using System;
using System.Collections.Generic;

namespace MenuShell.Views
{
    class SearchUserView : BaseView
    { 
        private Dictionary<string, User> users;

        public SearchUserView(Dictionary<string, User> users) : base("Search user view")
        {
            this.users = users;
        }

        public List<string> Display()//returnera list ist för user eftersom det blir mer än en
        {
            Console.Clear();

            Console.WriteLine("Search by username: \n");
            Console.Write(">");
            var input = Console.ReadLine();

            Console.Clear();
            

            List<string> searchResult = new List<string>();

            foreach (var entry in users)
            {
                if (entry.Key.Contains(input))
                {
                    searchResult.Add(entry.Key);
                }
            }

            searchResult.ForEach(Console.WriteLine);
            Console.WriteLine("\n(D)elete?");

            return searchResult;// ska matas in i listUser view
        }
    }
}
