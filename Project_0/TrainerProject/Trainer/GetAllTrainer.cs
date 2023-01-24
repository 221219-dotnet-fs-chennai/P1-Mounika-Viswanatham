/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class GetTrainer : IMenu
    {
        public void Display()
        {
            Console.WriteLine("[0] Login");
            Console.WriteLine("[1] Signup");
            Console.WriteLine("[2] Menu");

        }
        public string UserChoice()
        {
            Console.WriteLine("Enter Your Option");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Login";
                case "1":
                    return "Signup";
                case "2":
                    return "Menu";
                default:
                    Console.WriteLine("OOPS Please enter a valid input");
                    Console.WriteLine("Please press enter to continue");
                    Console.ReadLine();
                    return "Login";
            }
        }
    }
}
*/