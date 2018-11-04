using MenuShell.Domain;
using MenuShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MenuShell.Views
{
    class DeleteUsersView : BaseView
    {
        
        public List<User> searchResult;
        //private Dictionary<string, User> Users;

        public DeleteUsersView(List<User> searchResult) : base ("Delete users view") //tog bort "Dictionary<string, User> users" ur konstruktorn
        {
            this.searchResult = searchResult;
            //Users = users;
        }

        public void Display()
        {
            var users = new AuthenticationService().LoadUsers();

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


                if (users.Where(x => x.UserName.Contains(deleteUsername)).Count() > 0)//HÄR ÄR JAG 
                {
                    SqlDeleteUser.DeleteUser(deleteUsername);
                    //Users.Remove(deleteUsername);
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
