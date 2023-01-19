// See https://aka.ms/new-console-template for more information
using Trainer;
using Data;
namespace Trainer
{
   class Program : TrainerSignUp
    {
        
        static void Main(string[] args)
        {
            bool repeat = true;
            IMenu menu = new Menu();
            while(repeat)
            {
                menu.Display();
                string ans = menu.UserChoice();
                switch(ans)
                {
                    case "Login":
                        menu = new Login();
                        break;
                    case "Signup":
                        menu = new TrainerSignUp();
                        break;
                    case "Menu":
                        menu = new Menu();
                        break;
                    case "Exit":
                        repeat = false;
                        break;
                    case "Profile":
                        menu = new Profile(newTrainer);
                        break;
                    default:
                        Console.WriteLine("Page Doesnt Exist !");
                        Console.WriteLine("Enter to Continue");
                        Console.ReadLine();
                        break;


                }
            }
        }

    }
}