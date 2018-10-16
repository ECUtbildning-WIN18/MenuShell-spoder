using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class VeterinarianMainView : BaseView
    {
        public VeterinarianMainView() : base("Veterinarian main view")
        {

        }

        private bool IsRunning = true;
        public bool Display()
        {
            while (IsRunning)
            {
                Console.WriteLine("1. View appointments");
                Console.WriteLine("2. Edit journal");
                Console.Write("> ");

                var key = ConsoleKey.NoName;

                while (key != ConsoleKey.D1 && key != ConsoleKey.D2 && key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                }

           
                switch (key)
                {
                    case ConsoleKey.D1:
                    {
                        Console.WriteLine(
                            "You chose to edit journals\n Menu currently under construction, please check back later.");
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        Console.WriteLine(
                            "You chose to view appointments.\n Menu currently under construction, please check back again in 3 years.");
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        IsRunning = false;
                        break;
                    }
                }
            }
            return true;
        }
    }
}
