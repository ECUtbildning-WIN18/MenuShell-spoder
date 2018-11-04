using System.Collections.Generic;
using MenuShell.Domain;
using MenuShell.Services;
using MenuShell.Views;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var authenticate = new AuthenticationService();//tog bort users som inparameter
            var loginView = new LoginView(authenticate);

            bool isRunning = true;
            while (isRunning)
            {
                var validUser = loginView.Display();

                if(validUser != null)
                {
                    switch (validUser.Role)
                    {
                        case Role.Admin:
                            {
                                var View = new AdministratorMainView();//tog bort users som inparameter
                                View.Display();
                                break;
                            }
                        case Role.Receptionist:
                            {
                                break;
                            }
                        case Role.Veterinarian:
                            {
                                var VetView = new VeterinarianMainView();
                                VetView.Display();
                                break;
                            }
                    }
                }
            }

            //string connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";

            //string queryString = "SELECT * FROM Users";

            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var sqlCommand = new SqlCommand(queryString, connection);
                
            //    connection.Open();

            //    var reader = sqlCommand.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"{reader[0]}");
            //    }
            //    reader.Close();
            //}

        }
    }
}
