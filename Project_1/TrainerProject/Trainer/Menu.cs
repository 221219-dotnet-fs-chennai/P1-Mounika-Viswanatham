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
        }

        public string UserChoice()
        {
            string? userInput = Console.ReadLine();
            switch(userInput)
            {
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
