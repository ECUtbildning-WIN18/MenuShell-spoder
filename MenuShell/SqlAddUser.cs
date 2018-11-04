using MenuShell.Domain;
using System.Data.SqlClient;

namespace MenuShell
{
    class SqlAddUser
    {

        public static void AddUser(User user)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

            connection = new SqlConnection(connectionString);

            connection.Open();

            sql = $"INSERT INTO Users VALUES ( '{user.UserName}', '{user.PassWord}', '{user.Role}')";

            //sql = "INSERT INTO Users VALUES('John', 'John', 'Veterinarian')"; //.tostring

            command = new SqlCommand(sql, connection);

            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            connection.Close();
        }

    }
}
