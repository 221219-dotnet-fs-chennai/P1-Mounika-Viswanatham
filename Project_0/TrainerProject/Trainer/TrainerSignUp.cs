using Data;
using System.Text.RegularExpressions;

namespace Trainer
{
    internal class TrainerSignUp : IMenu
    {

        internal static Trainerdata newTrainer = new Trainerdata();
        static string constr = File.ReadAllText("../../../connectionString.txt");

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
            Console.WriteLine("\n ------------------ENTER INFORMATION-------------------\n");
            Console.WriteLine("[0] Menu  ");
            Console.WriteLine("[1] EmailId          :   " + newTrainer.EmailID);
            Console.WriteLine("[2] Name             :   " + newTrainer.Name);
            Console.WriteLine("[3] Age              :   " + newTrainer.Age);
            Console.WriteLine("[4] Gender           :   " + newTrainer.Gender);
            Console.WriteLine("[5] Phone Number     :   " + newTrainer.PhoneNumber);
            Console.WriteLine("[6] Password         :   " + newTrainer.Password);
            Console.WriteLine("[7] Location         :   " + newTrainer.Location);
            //Console.WriteLine("[8] WebsiteLink :  " + newTrainer.WebsiteLink);
            Console.WriteLine("[8] Institution Name :   " + newTrainer.institutionName);
            Console.WriteLine("[9] Degree           :   " + newTrainer.Degree);
            Console.WriteLine("[10] Specialization  :   " + newTrainer.Specialization);
            Console.WriteLine("[11] PassingYear     :   " + newTrainer.PassingYear);
            Console.WriteLine("[12] Skill1          :   " + newTrainer.Skill1);
            Console.WriteLine("[13] Skill2          :   " + newTrainer.Skill2);
            Console.WriteLine("[14] Skill3          :   " + newTrainer.Skill3);
            Console.WriteLine("[15] CompanyName     :   " + newTrainer.CompanyName);
            Console.WriteLine("[16] Experience      :   " + newTrainer.Experience);
            //Console.WriteLine("[17] Position : " + newTrainer.Position);
            Console.WriteLine("[17] To Save");
          
           


        }
        public string UserChoice()
        {
            //Console.WriteLine("---COLLECTING INGORMATION---");
            Console.WriteLine("\n");
            Console.WriteLine("--------------Enter your choice----------------------\n");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Menu";

                case "1":
                    Log.Logger.Information("Enter EmailID");
                    Console.WriteLine("Enter EmailID :  ");
                    string Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

                    string Email = Console.ReadLine();

                    if (Regex.IsMatch(Email, Pattern))
                    {
                        newTrainer.EmailID = Email;
                    }
                    else
                    {
                        Console.WriteLine("---Wrong Email Format--");

                    }
                    return "Signup";
                case "2":
                    Log.Logger.Information("Name");
                    Console.WriteLine("Enter Name :    ");
                    string pattern5 = "^[A-Za-z\\s]+$";
                    string name = Console.ReadLine();
                    if(Regex.IsMatch(name, pattern5))
                    {
                        newTrainer.Name = name;
                    }
                    else
                    {
                        Console.WriteLine("Name Should contain only letters and space");
                    }
                    return "Signup";
                case "3":
                    Log.Logger.Information("Age");
                    Console.WriteLine("Enter Age :  ");
                    string age= Console.ReadLine();
                    string pattern4 = "^(\\d{2})$";
                    if (Regex.IsMatch(age, pattern4))
                    {
                        newTrainer.Age = age;
                    }
                    else
                    {
                        Console.WriteLine("Age should be grater than 20");
                    }
                    //newTrainer.Age = Console.ReadLine();
                    return "Signup";
                case "4":
                    Log.Logger.Information("Gender");
                    Console.WriteLine("Enter Gender : Female / Male  :  ");
                    newTrainer.Gender = Console.ReadLine();
                    return "Signup";
                case "5":
                    Log.Logger.Information("PhoneNumber");
                    Console.WriteLine("Enter PhoneNumber :  ");
                    string Pattern1 = "^\\d{10}$";
                    string phonenumber = Console.ReadLine();
                    if (Regex.IsMatch(phonenumber, Pattern1))
                    {
                        newTrainer.PhoneNumber = phonenumber;
                    }
                    else
                    {
                        Console.WriteLine("---Number should have 10 digits---");
                    }
                    return "Signup";
                case "6":
                    Log.Logger.Information("Password");
                    Console.WriteLine("Create Your Password");
                    string pattern3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*]).{8,}$";
                    string password = Console.ReadLine();
                    if (Regex.IsMatch(password, pattern3))
                    {
                        newTrainer.Password = password;
                    }
                    else
                    {
                        Console.WriteLine("---Wrong Format Password-----\n");
                        Console.WriteLine("------Password contain at least one Capital Letter,Small Letter,Special character,Number-----\n");
                    }
                    return "Signup";
                case "7":
                    Log.Logger.Information("Location");
                    Console.WriteLine("Enter Location :  ");
                    newTrainer.Location = Console.ReadLine();
                    return "Signup";
               /* case "8":
                    Console.WriteLine("Enter WebsiteLink :  ");
                    newTrainer.WebsiteLink = Console.ReadLine();
                    return "Signup";*/
                case "8":
                    Log.Logger.Information("Institution Name");
                    Console.WriteLine("Enter Institution Name :  ");
                    newTrainer.institutionName = Console.ReadLine();
                    return "Signup";
                case "9":
                    Log.Logger.Information("Degree");
                    Console.WriteLine("Enter Degree :  ");
                    newTrainer.Degree = Console.ReadLine();
                    return "Signup";
                case "10":
                    Log.Logger.Information("Specialization");
                    Console.WriteLine("Enter Specialization :  ");
                    newTrainer.Specialization = Console.ReadLine();
                    return "Signup";
                case "11":
                    Log.Logger.Information("Passing Year");
                    Console.WriteLine("Enter PassingYear :  ");
                    string year= Console.ReadLine();
                    string pattern12 = @"\d{4}$";
                    if (Regex.IsMatch(year, pattern12))
                    {
                        newTrainer.PassingYear = year;
                    }
                    else
                    {
                        Console.WriteLine("enter year in digits  ");
                    }
                    return "Signup";
                case "12":
                    Log.Logger.Information("Skill1");
                    Console.WriteLine("Enter Skill1 :  ");
                    newTrainer.Skill1 = Console.ReadLine();
                    return "Signup";
                case "13":
                    Log.Logger.Information("Skill2");
                    Console.WriteLine("Enter Skill2 :  ");
                    newTrainer.Skill2 = Console.ReadLine();
                    return "Signup";
                case "14":
                    Log.Logger.Information("Skill3");
                    Console.WriteLine("Enter SKill3 :  ");
                    newTrainer.Skill3 = Console.ReadLine();
                    return "Signup";
                case "15":
                    Log.Logger.Information("CompanyName");
                    Console.WriteLine("Enter CompanyName :  ");
                    newTrainer.CompanyName = Console.ReadLine();
                    return "Signup";
                case "16":
                    Log.Logger.Information("Experience");
                    Console.WriteLine("Enter Experience :  ");
                    string patern = @"^(?:[1-9]|[1-4][0-9]|50)$";
                    string experience = Console.ReadLine();
                    if(Regex.IsMatch(experience, patern))
                    {
                        newTrainer.Experience = experience;
                    }
                    else
                    {
                        Console.WriteLine("enter experience below 51");
                    }
                    
                    return "Signup";
                /*case "17":
                    Log.Logger.Information("Position");
                    Console.WriteLine("Enter Your Position in Company :  ");
                    newTrainer.Position = Console.ReadLine();
                    return "Signup";*/
                case "17":
                    try
                    {
                        repo.Add(newTrainer);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fields cannot be Empty");
                        return "Signup";
                    }
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

