global using Serilog;
using Trainer;
using Data;
namespace Trainer
{
   class Program : TrainerSignUp
    {
        
     
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"..\..\..\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true).CreateLogger();

            Log.Logger.Information("Program starts");
            bool repeat = true;
            IMenu menu = new Menu();
            while(repeat)
            {
                menu.Display();
                string ans = menu.UserChoice();
                switch(ans)
                {
                    case "Login":
                        Log.Logger.Information("Login Page");
                        menu = new Login();
                        break;
                    case "Signup":
                        Log.Logger.Information("SignUp Page");
        
                        menu = new TrainerSignUp();
                        break;
                    case "Menu":
                        Log.Logger.Information("Menu Page");
                        newTrainer = new Trainerdata();
                        menu = new Menu();
                        break;
                    case "Exit":
                        Log.Logger.Information("Exit Page");
                        repeat = false;
                        break;
                    case "Profile":
                        Log.Logger.Information("Profile Page");
                        menu = new Profile(newTrainer);
                        break;
                    case "TrainerUpdate":
                        Log.Logger.Information("Update details");
                        menu = new TrainerUpdate();
                        break;
                    default:
                        Console.WriteLine("---------Page Doesnt Exist !----------");
                        Console.WriteLine("---------Enter to Continue------------");
                        Console.ReadLine();
                        break;


                }
            }
        }

    }
}