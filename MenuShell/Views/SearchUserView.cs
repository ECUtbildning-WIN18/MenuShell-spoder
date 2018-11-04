using MenuShell.Domain;
using MenuShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MenuShell.Views
{
    class SearchUserView : BaseView
    { 

        private bool IsRunning = true;

        public SearchUserView() : base("Search user view")
        {

        }

        public List<User> Display()//returnera list med users ist för user eftersom det blir mer än en
        {
            var users = new AuthenticationService().LoadUsers();

            while (IsRunning)
            {
                Console.Clear();

                Console.WriteLine("Search by username: \n");
                Console.Write(">");
                var input = Console.ReadLine();

                Console.Clear();

                var searchResult = users.Where(x => x.UserName.Contains(input)).ToList();

                if (searchResult.Any())
                {
                    foreach(var user in searchResult)
                    {
                        Console.WriteLine(searchResult);
                    }
                    //searchResult.Add(entry.Value);
                    //nu returnerar den all information om users som matchade resultatet. Kan ändra i list user sen till bara anv-namn.
                    IsRunning = false;
                }
                else
                {
                    Console.WriteLine("No users found matching the search term " + input);
                    Thread.Sleep(2000);
                }

                return searchResult;// ska matas in i listUser view
            }

            //searchResult.ForEach(Console.WriteLine);
            return null;

            
        }
    }
}
