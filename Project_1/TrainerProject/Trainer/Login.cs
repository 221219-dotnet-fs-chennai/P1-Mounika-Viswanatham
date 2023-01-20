using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Trainer
{
    public class Login : IMenu
    {
        static string conStr = $"Server = MOUNIKA; Database=Trainerdbase;Trusted_Connection=True;";

        IRepo repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Login Page");
            Console.WriteLine("[0] Menu");
            Console.WriteLine("[1] proceed to login");
        }
        public string UserChoice()
        {
            Console.WriteLine("Enter your Choice");
            string? str = Console.ReadLine();
            switch (str)
            {
                case "0":
                    return "GetTrainer";
                case "1":
                    Console.WriteLine("Enter Your Email");
                    string EmailID = Console.ReadLine();
                    bool result = repo.Login(EmailID);
                    if(result)
                    {
                        TrainerSignUp tSignup= new TrainerSignUp(repo.GetATrainer(EmailID));
                        
                        return "Profile";
                    }
                    else
                    {
                        return "Login";
                    }
                default:
                    Console.WriteLine("Wrong choice");
                    return "Login";

            }

        }

    }
}
