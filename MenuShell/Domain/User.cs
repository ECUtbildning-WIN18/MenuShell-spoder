using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Domain
{
    public class User
    {
        public string UserName { get; }
        public string PassWord { get; }
        public Role Role { get; }

        public User(string userName, string passWord, Role role)
        {
            UserName = userName;
            PassWord = passWord;
            Role = role;
        }

        public override string ToString()
        {
            return string.Format($"{UserName} {PassWord} {Role}");
        }
    }

}
