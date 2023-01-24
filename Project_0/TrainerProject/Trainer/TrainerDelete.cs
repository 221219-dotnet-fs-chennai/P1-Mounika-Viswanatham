using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainer
{
    internal class TrainerDelete : TrainerSignUp, IMenu
    {
        static string constr = File.ReadAllText("../../../connectionString.txt");

        IRepo repo = new SqlRepo(constr);

        public void Display()
        {
            Console.WriteLine("[0] Go Back  ");
            Console.WriteLine("[1] Name             : " + newTrainer.Name);
           // Console.WriteLine("[2] EmailId  :" + newTrainer.EmailID);
            Console.WriteLine("[2] PhoneNumber      : " + newTrainer.PhoneNumber);
         //   Console.WriteLine("[4] Password  : " + newTrainer.Password);
            Console.WriteLine("[3] Age              : " + newTrainer.Age);
            Console.WriteLine("[4] Institution Name : " + newTrainer.institutionName);
            Console.WriteLine("[5] Degree           : " + newTrainer.Degree);
            Console.WriteLine("[6] Specialization   : " + newTrainer.Specialization);
            Console.WriteLine("[7] Passing Year     : " + newTrainer.PassingYear);
            Console.WriteLine("[8] Skill1           : " + newTrainer.Skill1);
            Console.WriteLine("[9] Skill2           : " + newTrainer.Skill2);
            Console.WriteLine("[10] Skill3          : " + newTrainer.Skill3);
            Console.WriteLine("[11] CompanyName     : " + newTrainer.CompanyName);
            Console.WriteLine("[12] Experience      : " + newTrainer.Experience);
            Console.WriteLine("[13] Location        : " + newTrainer.Location);
        }
        public string UserChoice()
        {
            //throw new NotImplementedException();
            string[] arr = newTrainer.EmailID.Split("@");
            string userId = arr[0];
            Console.WriteLine("Enter the choice you want to Delete");

            string str = Console.ReadLine();
            switch (str)
            {
                case "0":

                    return "Profile";

                case "1":

                    Log.Logger.Information("Delete Name");

                    Console.WriteLine("Deleting NAME");
                    newTrainer.Name = "";
                    repo.TrainerDelete("Name", "TrainerDetails", userId);
                    break;

                /*case "2":

                    Log.Logger.Information("Delete EmailID");

                    repo.TrainerDelete("EmailID", "TrainerDetails", userId);
                    //repo.TrainerUpdate(email, "EmailID", "TrainerDEtails", userId);

                    break;*/

                case "2":

                    Log.Logger.Information("Delete PhoneNumber");
                    /*Console.WriteLine("Enter the new PhoneNumber");
                    string phonenumber = Console.ReadLine();
                    string Pattern1 = "^\\d{10}$";
                    if (Regex.IsMatch(phonenumber, Pattern1))
                    {
                        newTrainer.PhoneNumber = phonenumber;
                    }
                    else
                    {
                        Console.WriteLine("---PhoneNumber Should Contain 10 Digits");
                    }*/
                    Console.WriteLine("Deleting PHONENUMBER");

                    newTrainer.PhoneNumber = " ";

                    repo.TrainerDelete("PhoneNumber", "TrainerDetails", userId);

                    break;

                /*case "4":

                    Log.Logger.Information("Delete Password");
                    *//*Console.WriteLine("Enter the new Password");
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
                    }*//*
                    repo.TrainerDelete("Password", "TrainerDetails", userId);

                    break;*/

                case "3":

                    Log.Logger.Information("Delete Age");

                    Console.WriteLine("Deleting AGE");

                    newTrainer.Age = " ";

                    repo.TrainerDelete ("Age", "TrainerDetails", userId);

                    break;

                case "4":

                    Log.Logger.Information("Delete Institution Name");

                    Console.WriteLine("Deleting INSTITUTE Name");

                    newTrainer.institutionName = " ";
                   
                    repo.TrainerDelete( "institutionName", "Education_Details", userId);

                    break;

                case "5":

                    Log.Logger.Information("Delete Degree");

                    Console.WriteLine("Deleting DEGREE");

                    newTrainer.Degree = " ";
                  
                    repo.TrainerDelete( "Degree", "Education_Details", userId);

                    break;

                case "6":

                    Log.Logger.Information("Delete Specialization");

                    Console.WriteLine("Deleting SPECIALIZATION");

                    newTrainer.Specialization = " ";
                  
                    repo.TrainerDelete( "Specialization", "Education_Details", userId);

                    break;

                case "7":

                    Log.Logger.Information("Delete PassingYear");

                    Console.WriteLine("Deleting PASSINGYEAR");

                    newTrainer.PassingYear = " ";
                   
                    repo.TrainerDelete( "PassingYear", "Education_Details", userId);

                    break;

                case "8":

                    Log.Logger.Information("Delete Skill1");

                    Console.WriteLine(" Deleting Skill1");

                    newTrainer.Skill1= " ";
                   
                    repo.TrainerDelete( "Skill1", "Skill_Details", userId);

                    break;


                case "9":

                    Log.Logger.Information("Delete Skill2");

                    Console.WriteLine("Deleting Skill2");

                    newTrainer.Skill2= " ";
                  
                    repo.TrainerDelete( "Skill2", "Skill_Details", userId);

                    break;

                case "10":
                    Log.Logger.Information("Delete  Skill3");

                    Console.WriteLine("Deleting SKILL3");

                    newTrainer.Skill3= " ";
                    
                    repo.TrainerDelete( "Skill3", "Skill_Details", userId);
                    break;

                case "11":

                    Log.Logger.Information("Delete Comapny name");

                    Console.WriteLine("Deleting COMPANY Name");

                    newTrainer.CompanyName= " ";
                  
                    repo.TrainerDelete( "CompanyName", "Compaby_Detail", userId);

                    break;

                case "12":

                    Log.Logger.Information("Delete experience");

                    Console.WriteLine("Deleting EXPERIENCE");

                    newTrainer.Experience= " ";
                    
                    repo.TrainerDelete( "Experience", "Company_Detail", userId);

                    break;
                case "13":

                    Log.Logger.Information("Delete Location");

                    Console.WriteLine("Deleting LOCATION");

                    newTrainer.Location= " ";
                   
                    repo.TrainerDelete( "Location", "TrainerDetails", userId);

                    break;

                default:

                    Log.Logger.Information("Wrong choice");
                    Console.WriteLine("You have Entered Wrong Choice");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    break;


            }
            return "Profile";
        }
    }
}
