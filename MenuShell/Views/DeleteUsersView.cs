using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MenuShell.Views
{
    class DeleteUsersView : BaseView
    {
        public List<User> searchResult;
        private Dictionary<string, User> users;

        public DeleteUsersView(List<User> searchResult, Dictionary<string, User> users) : base ("Delete users view")
        {
            this.searchResult = searchResult;
            this.users = users;
        }

        public void Display()
        {
            bool isRunning = true;
            while (isRunning)
            {
                foreach (var result in searchResult)
                {
                    Console.WriteLine(result.UserName);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Please enter the user you want to delete: \n");
                Console.Write("Username: ");

                var deleteUsername = Console.ReadLine();


                if (users.ContainsKey(deleteUsername))
                {
                    users.Remove(deleteUsername);
                    Console.Clear();
                    Console.WriteLine($"Successfully deleted {deleteUsername}");
                    Thread.Sleep(2000);
                    isRunning = false;
                }
            }
        }
        //en for-loop som loopar igenom users, kollar användarens input, return user
    }
}
