using Data;
using System.Text.RegularExpressions;

namespace Trainer
{
    internal class TrainerSignUp : IMenu
    {

        internal static Trainerdata newTrainer = new Trainerdata();
        static string constr = @"Server=MOUNIKA;Database=Trainerdbase;Trusted_Connection=True;";
        SqlRepo repo = new SqlRepo(constr);

        public TrainerSignUp(Trainerdata td)
            {
            newTrainer = td;
            }
        public TrainerSignUp()
        {

        }
        public void Display()
        {
                Console.WriteLine("\n Enter Information ");
                Console.WriteLine("[0] Menu  ");
                Console.WriteLine("[1] EmailId :  " + newTrainer.EmailID);
                Console.WriteLine("[2] Name :   " + newTrainer.Name);
                Console.WriteLine("[3] Age :  " + newTrainer.Age);
                Console.WriteLine("[4] Gender  :   " + newTrainer.Gender);
                Console.WriteLine("[5] Phone Number :  " + newTrainer.PhoneNumber);
                Console.WriteLine("[6] Password :  " + newTrainer.Password);
                Console.WriteLine("[7] Location :  " + newTrainer.Location);
                //Console.WriteLine("[8] WebsiteLink :  " + newTrainer.WebsiteLink);
                Console.WriteLine("[8] Institution Name :  " + newTrainer.institutionName);
                Console.WriteLine("[9] Degree :  " + newTrainer.Degree);
                Console.WriteLine("[10] Specialization:  " + newTrainer.Specialization);
                Console.WriteLine("[11] PassingYear : " + newTrainer.PassingYear);
                Console.WriteLine("[12] Skill1 : " + newTrainer.Skill1);
                Console.WriteLine("[13] Skill2 : " + newTrainer.Skill2);
                Console.WriteLine("[14] Skill3 : " + newTrainer.Skill3);
                Console.WriteLine("[15] CompanyName :  " + newTrainer.CompanyName);
                Console.WriteLine("[16] Experience : " + newTrainer.Experience);
                Console.WriteLine("[17] Position : " + newTrainer.Position);
                Console.WriteLine("[18] To Save");


        }
        public string UserChoice()
        {
            Console.WriteLine("Collecting Information");
            Console.WriteLine("Enter your choice");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    Console.WriteLine("Enter EmailID :  ");
                    string Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

                    string Email = Console.ReadLine();
                    if(Regex.IsMatch(Email,Pattern))
                    {
                        newTrainer.EmailID = Email;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Email Format");
                       
                    }
                    return "Signup";
                case "2":
                    Console.WriteLine("Enter Name :  ");
                    newTrainer.Name = Console.ReadLine();
                    return "Signup";
                case "3":
                    Console.WriteLine("Enter Age :  ");
                    newTrainer.Age = Console.ReadLine();
                    return "Signup";
                case "4":

                    Console.WriteLine("Enter Gender : Female / Male  :  ");
                    newTrainer.Gender = Console.ReadLine();
                    return "Signup";
                case "5":
                    Console.WriteLine("Enter PhoneNumber :  ");
                    string Pattern1 = "^\\d{10}$";
                    string phonenumber = Console.ReadLine();
                    if(Regex.IsMatch(phonenumber,Pattern1))
                    {
                        newTrainer.PhoneNumber= phonenumber;
                    }
                   else
                    {
                        Console.WriteLine("Number should have 10 digits");
                    }    
                    return "Signup";
                case "6":
                    Console.WriteLine("Create Your Password");
                    string pattern3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*]).{8,}$";
                    string password = Console.ReadLine();
                    if(Regex.IsMatch(password,pattern3))
                    {
                        newTrainer.Password = password;
                    }
                   else
                    {
                        Console.WriteLine("Wrong Format Password");
                        Console.WriteLine("Password contain at least one Capital Letter,Small Letter,Special character,Number");
                    }
                    return "Signup";
                case "7":
                    Console.WriteLine("Enter Location :  ");
                    newTrainer.Location = Console.ReadLine();
                    return "Signup";
                /*case "8":
                    Console.WriteLine("Enter WebsiteLink :  ");
                    newTrainer.WebsiteLink = Console.ReadLine();
                    return "Signup";*/
                case "8":
                    Console.WriteLine("Enter Institution Name :  ");
                    newTrainer.institutionName = Console.ReadLine();
                    return "Signup";
                case "9":
                    Console.WriteLine("Enter Degree :  ");
                    newTrainer.Degree = Console.ReadLine();
                    return "Signup";
                case "10":
                    Console.WriteLine("Enter Specialization :  ");
                    newTrainer.Specialization = Console.ReadLine();
                    return "Signup";
                case "11":
                    Console.WriteLine("Enter PassingYear :  ");
                    newTrainer.PassingYear = Console.ReadLine();
                    return "Signup";
                case "12":
                    Console.WriteLine("Enter Skill1 :  ");
                    newTrainer.Skill1 = Console.ReadLine();
                    return "Signup";
                case "13":
                    Console.WriteLine("Enter Skill2 :  ");
                    newTrainer.Skill2 = Console.ReadLine();
                    return "Signup";
                case "14":
                    Console.WriteLine("Enter SKill3 :  ");
                    newTrainer.Skill3 = Console.ReadLine();
                    return "Signup";
                case "15":
                    Console.WriteLine("Enter CompanyName :  ");
                    newTrainer.CompanyName = Console.ReadLine();
                    return "Signup";
                case "16":
                    Console.WriteLine("Enter Experience :  ");
                    newTrainer.Experience = Console.ReadLine();
                    return "Signup";
                case "17":
                    Console.WriteLine("Enter YOur Position in Company :  ");
                    newTrainer.Position = Console.ReadLine();
                    return "Signup";
                case "18":
                    repo.Add(newTrainer);
                    return "Profile";

                default:
                    Console.WriteLine("please input a valid respone");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "Signup";

            }


        }         
        
                
     }


}

