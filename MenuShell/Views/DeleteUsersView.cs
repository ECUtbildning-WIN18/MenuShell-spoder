using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MenuShell.Views
{
    class DeleteUsersView : BaseView
    {
        private Dictionary<string, User> users;

        public DeleteUsersView(Dictionary<string, User> users) : base ("Delete users view")
        {
            this.users = users;
        }

        public void Display()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Please enter the user you want to delete: ");
                Console.Write("Username: ");

                var deleteUsername = Console.ReadLine();


                if (users.ContainsKey(deleteUsername))
                {
                    users.Remove(deleteUsername);
                    Console.Clear();
                    Console.WriteLine($"Deleted {deleteUsername}");
                    Thread.Sleep(2000);
                    isRunning = false;
                }
            }
        }
        //en for-loop som loopar igenom users, kollar användarens input, return user
    }
}
