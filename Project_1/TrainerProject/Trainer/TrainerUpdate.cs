using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Data;

namespace Trainer
{
    internal class TrainerUpdate : TrainerSignUp, IMenu
    {
        //static string connectionString = File.ReadAllText("..\..\..\connectionString.txt");

        static string connectionString = File.ReadAllText("../../../connectionString.txt");

        IRepo repo = new SqlRepo(connectionString);
        public new void Display()
        {
            //throw new NotImplementedException();

            /* Console.WriteLine("[0]");
             Console*/
            Console.WriteLine("---------------------------------");
            Console.WriteLine("[0] go Back");
            Console.WriteLine("[1] Continue to Update Details");

        }

        public string UserChoice()
        {
            //throw new NotImplementedException();
            string str = Console.ReadLine();
            switch (str)
            {
                case "0":
                    return "Profile";

                case "1":
                    Log.Logger.Information("Update Name");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("[0] Go Back");
                    Console.WriteLine("[1] Name             : " + newTrainer.Name);
                    Console.WriteLine("[2] EmailId          : " + newTrainer.EmailID);
                    Console.WriteLine("[3] PhoneNumber      : " + newTrainer.PhoneNumber);
                    Console.WriteLine("[4] Password         : " + newTrainer.Password);
                    Console.WriteLine("[5] Age              : " + newTrainer.Age);
                    Console.WriteLine("[6] Institution Name : " + newTrainer.institutionName);
                    Console.WriteLine("[7] Degree           : " + newTrainer.Degree);
                    Console.WriteLine("[8] Specialization   : " + newTrainer.Specialization);
                    Console.WriteLine("[9] Passing Year     : " + newTrainer.PassingYear);
                    Console.WriteLine("[10] Skill1          : " + newTrainer.Skill1);
                    Console.WriteLine("[11] Skill2          : " + newTrainer.Skill2);
                    Console.WriteLine("[12] Skill3          : " + newTrainer.Skill3);
                    Console.WriteLine("[13] CompanyName     : " + newTrainer.CompanyName);
                    Console.WriteLine("[14] Experience      : " + newTrainer.Experience);
                    Console.WriteLine("[15] Location        : " + newTrainer.Location);

                    Console.WriteLine(" Enter choice you want to Update");

                    string n = Console.ReadLine();
                    string[] arr = newTrainer.EmailID.Split("@");
                    string userId = arr[0];
                    if(n=="0")
                    {
                        return "Profile";
                    }


                    if (n == "1")
                    {
                        Log.Logger.Information("new Name");
                        Console.WriteLine("Enter the new Name");
                        string? pattern5 = "^[A-Za-z\\s]+$";
                        string? name = Console.ReadLine();
                        if (Regex.IsMatch(name, pattern5))
                        {
                            newTrainer.Name = name;
                        }
                        else
                        {
                            Console.WriteLine("Name Should only contain letters and  space");
                        }
                        repo.TrainerUpdate(name, "Name", "TrainerDetails", userId);
                        return "Profile";

                    }
                    if (n == "2")
                    {
                        Log.Logger.Information("Update EmailID");
                        Console.WriteLine("Enter the new EmailID");
                        string? email = Console.ReadLine();
                        string pattern = @$"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$\";
                        if (Regex.IsMatch(email, pattern))
                        {
                            newTrainer.EmailID = email;
                        }
                        else
                        {
                            Console.WriteLine("---Wrong Email Format---");
                        }

                        repo.TrainerUpdate(email, "EmailID", "TrainerDetails", userId);

                        return "Profile";
                    }
                    if (n == "3")
                    {
                        Log.Logger.Information("Update PhoneNumber");
                        Console.WriteLine("Enter the new PhoneNumber");
                        string? phonenumber = Console.ReadLine();
                        string Pattern1 = "^\\d{10}$";
                        if (Regex.IsMatch(phonenumber, Pattern1))
                        {
                            newTrainer.PhoneNumber = phonenumber;
                        }
                        else
                        {
                            Console.WriteLine("---PhoneNumber Should Contain 10 Digits");
                        }
                        repo.TrainerUpdate(phonenumber, "PhoneNumber", "TrainerDetails", userId);
                        return "Profile";
                    }
                    if (n == "4")
                    {
                        Log.Logger.Information("Update Password");
                        Console.WriteLine("Enter the new Password");
                        string? password = Console.ReadLine();
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

                        repo.TrainerUpdate(password, "Password", "TrainerDetails", userId);
                        return "Profile";
                    }
                    if (n == "5")
                    {
                        Log.Logger.Information("Update Age");
                        Console.WriteLine("Enter the new Age");
                        string? age = Console.ReadLine();
                        string pattern4 = "^\\d{2}$";
                        if (Regex.IsMatch(age, pattern4))
                        {
                            newTrainer.Age = age;
                        }
                        else
                        {
                            Console.WriteLine("Age should be greater than 20");
                        }
                        repo.TrainerUpdate(age, "Age", "TrainerDetails", userId);
                        return "Profile";
                    }
                    if (n == "6")
                    {
                        Log.Logger.Information("Update Institution Name");
                        Console.WriteLine("Enter the new InstitutionName");
                        string? institutioname = Console.ReadLine();
                        string pattern6 = "^[A-Za-z\\s]+$";
                        if (Regex.IsMatch(institutioname, pattern6))
                        {
                            newTrainer.institutionName = institutioname;

                        }
                        else
                        {
                            Console.WriteLine("name should contain only letters and spaces");
                        }
                        repo.TrainerUpdate(institutioname, "institutionName", "Education_Details", userId);
                        return "Profile";
                    }
                    if (n == "7")
                    {
                        Log.Logger.Information("Update Degree");
                        Console.WriteLine("Enter the new Degree");
                        string? degree = Console.ReadLine();
                        newTrainer.Degree = degree;
                        repo.TrainerUpdate(degree, "Degree", "Education_Details", userId);
                        return "Profile";
                    }
                    if (n == "8")
                    {
                        Log.Logger.Information("Update Specialization");
                        Console.WriteLine("Enter the new Specialization");
                        string? specialization = Console.ReadLine();
                        newTrainer.Specialization = specialization;
                        repo.TrainerUpdate(specialization, "Specialization", "Education_Details", userId);
                        return "Profile";
                    }
                    if (n == "9")
                    {
                        Log.Logger.Information("Update PassingYear");
                        Console.WriteLine("Enter the new PassingYear");
                        string? passingyear = Console.ReadLine();
                        string pattern7 = @"\d{4}$";
                        if (Regex.IsMatch(passingyear, pattern7))
                        {
                            newTrainer.PassingYear = passingyear;

                        }
                        else
                        {
                            Console.WriteLine("Enter year in digits(4)");
                        }
                        repo.TrainerUpdate(passingyear, "PassingYear", "Education_Details", userId);


                        return "Profile";

                    }
                    if (n == "10")
                    {
                        Log.Logger.Information("Update Skill2");
                        Console.WriteLine("Enter the new Skill1");
                        string? skill1 = Console.ReadLine();
                        newTrainer.Skill1 = skill1;
                        repo.TrainerUpdate(skill1, "Skill1", "Skill_Details", userId);
                        return "Profile";
                    }
                    if (n == "11")
                    {
                        Log.Logger.Information("Update Skill2");
                        Console.WriteLine("Enter the new Skill2");
                        string? skill2 = Console.ReadLine();
                        newTrainer.Skill2 = skill2;
                        repo.TrainerUpdate(skill2, "Skill2", "Skill_Details", userId);
                        return "Profile";
                    }

                    if (n == "12")
                    {
                        Log.Logger.Information("Update  Skill3");
                        Console.WriteLine("Enter the new Skill3");
                        string? skill3 = Console.ReadLine();
                        newTrainer.Skill3 = skill3;
                        repo.TrainerUpdate(skill3, "Skill3", "Skill_Details", userId);
                        return "Profile";
                    }

                    if (n == "13")
                    {
                        Log.Logger.Information("Update Comapny name");
                        Console.WriteLine("Enter the new CompanyName");
                        string? companyname = Console.ReadLine();
                        newTrainer.CompanyName = companyname;
                        repo.TrainerUpdate(companyname, "CompanyName", "Compaby_Detail", userId);
                        return "Profile";
                    }

                    if (n == "14")
                    {
                        Log.Logger.Information("update experience");
                        Console.WriteLine("Enter the new Experience");
                        string? experience = Console.ReadLine();
                        string patern = @"^(?:[1-9]|[1-4][0-9]|50)$";
                        if (Regex.IsMatch(experience, patern))
                        {
                            newTrainer.Experience = experience;
                        }
                        else
                        {
                            Console.WriteLine("Enter Experience below 51");
                        }
                        // repo.TrainerUpdate(location, "Location", "TrainerDetails", userId);
                        repo.TrainerUpdate(experience, "Experience", "Company_Detail", userId);
                        return "Profile";
                    }

                    return "Profile";
                /*case "15":
                    break;*/
                default:
                    Console.WriteLine("You have Entered Wrong Choice");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    return "Profile";


            }

        }
    }
}
