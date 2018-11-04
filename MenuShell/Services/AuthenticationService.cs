using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MenuShell.Services
{
    class AuthenticationService : IAuthenticationService
    {
        private Dictionary<string, User> users;


        public List<User> LoadUsers()
        {
            var users = new List<User>();

            SqlConnection connection;
            SqlDataReader dataReader;
            SqlCommand command; 
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql, output = "";

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

            connection = new SqlConnection(connectionString);

            connection.Open();

            sql = "select * from Users";

            command = new SqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var username = dataReader["UserName"].ToString();
                var password = dataReader["PassWord"].ToString();
                var role = dataReader["Role"].ToString();
                var access = (Role)Enum.Parse(typeof(Role), role);

                users.Add(new User(username, password, access));
                //output = output + dataReader.GetValue(0) + "\n";
            }

            connection.Close();
            return users;
        }



        public User Authenticate(string Username, string password)
        {
            var users = new AuthenticationService().LoadUsers();
            var loggedUser = users.Find(x => x.UserName == Username && x.PassWord == password);
            //if (users.ContainsKey(Username) && users[Username].PassWord == password)
            //{

            //    return users[username];
            //}
            //else
            //{
            //    return null;
            //}

            return loggedUser;
        }
    }
}
