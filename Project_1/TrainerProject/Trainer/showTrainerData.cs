using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class showTrainerData : TrainerSignUp, IMenu
    {
        static string connectionString = File.ReadAllText("../../../connectionString.txt");

        IRepo repo = new SqlRepo(connectionString);
        Trainerdata newTrainer = new Trainerdata();
        public showTrainerData(Trainerdata tdata)
        {
            newTrainer = tdata;
        }
        public void Display()
        {
            //throw new NotImplementedException();
            Console.WriteLine("[0] to go back");
            Console.WriteLine("[1] Show Personls Details ");
            Console.WriteLine("[2] Show Educational Details");
            Console.WriteLine("[3] show Skills");
            Console.WriteLine("[4] show Company Details");
            Console.WriteLine("Please Enter Your choice:");
        }

        public string UserChoice()
        {
            //throw new NotImplementedException();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return "Profile";
                case "1":
                    Console.WriteLine("---------PERSONAL DETAILS--------\n");
                    Console.WriteLine(" EmailId :  " + newTrainer.EmailID);
                    Console.WriteLine(" Name :   " + newTrainer.Name);
                    Console.WriteLine(" Age :  " + newTrainer.Age);
                    Console.WriteLine(" Gender  :   " + newTrainer.Gender);
                    Console.WriteLine(" Phone Number :  " + newTrainer.PhoneNumber);
                    Console.WriteLine(" Password :  " + newTrainer.Password);
                    Console.WriteLine(" Location :  " + newTrainer.Location);
                    return "showTrainerData";
                case "2":
                    Console.WriteLine("----------EDUCATION DETAILS------------\n");
                    Console.WriteLine(" Institution Name :  " + newTrainer.institutionName);
                    Console.WriteLine(" Degree :  " + newTrainer.Degree);
                    Console.WriteLine(" Specialization:  " + newTrainer.Specialization);
                    Console.WriteLine(" PassingYear : " + newTrainer.PassingYear);
                    return "showTrainerData";
                case "3":
                    Console.WriteLine("-------------SKILL DETAILS---------\n");
                    Console.WriteLine(" Skill1 : " + newTrainer.Skill1);
                    Console.WriteLine(" Skill2 : " + newTrainer.Skill2);
                    Console.WriteLine(" Skill3 : " + newTrainer.Skill3);
                    return "showTrainerData";
                case "4":
                    Console.WriteLine("-------------COMPANY DETAILS----------\n");
                    Console.WriteLine(" CompanyName :  " + newTrainer.CompanyName);
                    Console.WriteLine(" Experience : " + newTrainer.Experience);
                    return "showTrainerData";

                default:
                    Console.WriteLine("WRONG CHOICE");
                    Console.WriteLine("Enter to continue");
                    Console.ReadLine();
                    return "showTrainerData";
            }

        }
    }
}