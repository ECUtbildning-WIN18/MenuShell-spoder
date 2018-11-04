using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MenuShell.Services
{
    class SqlGetData
    {
        public void SqlFetchData()
        {
            //Databas hemläxa-test------------------------------------------------------------------------------------------
            //Hämtar info från databasen.
            SqlConnection connection;
            SqlDataReader dataReader;
            SqlCommand command; //SqlCommand används till att läsa och skriva från databasen.
            SqlDataAdapter adapter = new SqlDataAdapter();// används för att ändra data i databasen.
            string sql, output = "";

            string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

            connection = new SqlConnection(connectionString);

            connection.Open();

            sql = "select Username,Role from Users";

            command = new SqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + "\n";
            }

            Console.WriteLine(output);

            connection.Close();
            command.Dispose();
            dataReader.Close();
            Console.ReadKey();

            //--------------------------------------------------------------------------------------------------------
        }
    }
    
}
