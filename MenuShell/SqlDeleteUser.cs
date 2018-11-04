using MenuShell.Domain;
using MenuShell.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MenuShell
{
    class SqlDeleteUser
    {
        public static void DeleteUser(string deleteUsername)
        {

            var users = new AuthenticationService().LoadUsers();

            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

            connection = new SqlConnection(connectionString);

            connection.Open();

            sql = $"DELETE FROM Users WHERE Username =( '{deleteUsername}' )";

            //sql = "INSERT INTO Users VALUES('John', 'John', 'Veterinarian')"; //.tostring

            command = new SqlCommand(sql, connection);

            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            connection.Close();
        }

    }
}
