using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class Menu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome Trainer  ");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Are You a New Trainer : Signup");
            Console.WriteLine("[2] Existing Trainer : Login");
            Console.WriteLine("[3] To Find Trainer By Email");
            Console.WriteLine("[4] To Find Trainer By Location");
            
        }

        public string UserChoice()
        {
            string? userInput = Console.ReadLine();
            switch(userInput)
            {
               
                case "4":
                    return "FindTrainerByLocation";
                case "3":
                    return "FindTrainerByEmail";
                case "2":
                     return "Login";
                case "1":
                    return "Signup";
                case "0":
                    return "Exit";
                default:
                    Console.WriteLine("OOPS Please enter a valid input");
                    Console.WriteLine("Please press enter to continue");
                    Console.ReadLine();
                    return "Menu";

            }
        }
    }
}
