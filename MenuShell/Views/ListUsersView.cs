using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class ListUsersView : BaseView
    {
        private Dictionary<string, User> users;

        public ListUsersView() : base("List users view")
        {
         
        }

       
    }
}
