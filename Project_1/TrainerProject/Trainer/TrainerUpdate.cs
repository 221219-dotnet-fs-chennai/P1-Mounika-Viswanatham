using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainer
{
    internal class TrainerUpdate :  TrainerSignUp , IMenu
    {
        public void Display()
        {
            //throw new NotImplementedException();

            Console.WriteLine("[0] Go Back");
            Console.WriteLine("[1] Name");
            Console.WriteLine("[2] EmailId");
            Console.WriteLine("[3] PhoneNumber");
            Console.WriteLine("[4] Password");
            Console.WriteLine("[5] Age");
            Console.WriteLine("[6] Institution Name");
            Console.WriteLine("[7] Degree");
            Console.WriteLine("[8] Specialization");
            Console.WriteLine("[9] Passing Year");
            Console.WriteLine("[10] Skill1");
            Console.WriteLine("[11] Skill2");
            Console.WriteLine("[12] Skill3");
            Console.WriteLine("[13] CompanyName");
            Console.WriteLine("[14] Experience");
           // Console.WriteLine("[15] save Updated Details");

        }

        public string UserChoice()
        {
            //throw new NotImplementedException();
            string str = Console.ReadLine();
            switch(str)
            {
                case "0":
                    return "Profile";
                case "1":
                    Log.Logger.Information("Update Name");
                    Console.WriteLine("Enter the new Name");
                    string name = Console.ReadLine();
                    newTrainer.Name = name;
                    break;
                case "2":
                    Log.Logger.Information("Update EmailID");
                    Console.WriteLine("Enter the new EmailID");
                    string email = Console.ReadLine();
                    string pattern= @$"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$\";
                    if (Regex.IsMatch(email, pattern))
                     {
                            newTrainer.EmailID = email;
                     }
                    else
                    {
                        Console.WriteLine("---Wrong Email Format---");
                    }
                   
                    break;
                case "3":
                    Log.Logger.Information("Update PhoneNumber");
                    Console.WriteLine("Enter the new PhoneNumber");
                    string phonenumber = Console.ReadLine();
                    string Pattern1 = "^\\d{10}$";
                    if (Regex.IsMatch(phonenumber, Pattern1))
                    {
                        newTrainer.PhoneNumber = phonenumber;
                    }
                    else
                    {
                        Console.WriteLine("---PhoneNumber Should Contain 10 Digits");
                    }
                    break;
                case "4":
                    Log.Logger.Information("Update Password");
                    Console.WriteLine("Enter the new Password");
                    string password = Console.ReadLine();
                    string pattern3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*]).{8,}$";
                    if (Regex.IsMatch(password, pattern3))
                    {
                        newTrainer.Password = password;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PassWord Format ");
                        Console.WriteLine("PassWord should contain atleast one capital letter and one small letter ,one special characters ,one number , equal to or more than 8  letters");
                    }
                    break;
                case "5":
                    Log.Logger.Information("Update Age");
                    Console.WriteLine("Enter the new Age");
                    string age = Console.ReadLine();
                    string pattern4 = "^(2[1 - 9] | 3[0 - 9] | 4[0 - 9])$"; 
                    if (Regex.IsMatch(age, pattern4))
                    {
                        newTrainer.Age = age;
                    }
                    else
                    {
                        Console.WriteLine("Age should be greater than 20");
                    }
                    break;
                case "6":
                    Log.Logger.Information("Update Institution Name");
                    Console.WriteLine("Enter the new InstitutionName");
                    string institutioname = Console.ReadLine();
                    newTrainer.institutionName= institutioname;
                    break;
                case "7":
                    Log.Logger.Information("Update Degree");
                    Console.WriteLine("Enter the new Degree");
                    string degree = Console.ReadLine();
                    newTrainer.Degree= degree;
                    break;
                case "8":
                    Log.Logger.Information("Update Specialization");
                    Console.WriteLine("Enter the new Specialization");
                    string specialization = Console.ReadLine();
                    newTrainer.Specialization= specialization;
                    break;
                case "9":
                    Log.Logger.Information("Update PassingYear");
                    Console.WriteLine("Enter the new PassingYear");
                    string passingyear = Console.ReadLine();
                    string pattern7 = @"\d{4}$";
                    if (Regex.IsMatch(passingyear, pattern7))
                    {
                        newTrainer.PassingYear = passingyear;

                    }
                    else
                    {
                        Console.WriteLine("Enter year in digits(4)");
                    }
                    break;
                case "10":
                    Log.Logger.Information("Update Skill2");
                    Console.WriteLine("Enter the new Skill1");
                    string skill1 = Console.ReadLine();
                    newTrainer.Skill1= skill1;
                    break;
                case "11":
                    Log.Logger.Information("Update Skill2");
                    Console.WriteLine("Enter the new Skill2");
                    string skill2 = Console.ReadLine();
                    newTrainer.Skill2= skill2;
                    break;
                case "12":
                    Log.Logger.Information("Update  Skill3");
                    Console.WriteLine("Enter the new Skill3");
                    string skill3 = Console.ReadLine();
                    newTrainer.Skill3= skill3;
                    break;
                case "13":
                    Log.Logger.Information("Update Comapny name");
                    Console.WriteLine("Enter the new CompanyName");
                    string companyname = Console.ReadLine();
                    newTrainer.CompanyName= companyname;
                    break;
                case "14":
                    Log.Logger.Information("update experience");
                    Console.WriteLine("Enter the new Experience");
                    string experience = Console.ReadLine();
                    string patern = @"^(?:[1-9]|[1-4][0-9]|50)$";
                    if (Regex.IsMatch(experience, patern))
                    {
                        newTrainer.Experience = experience;
                    }
                    else
                    {
                        Console.WriteLine("Enter Experience below 51");
                    }
                    break;
                /*case "15":
                    break;*/
                default:
                    Console.WriteLine("You have Entered Wrong Choice");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    break;


            }
            return "";
        }
    }
}
