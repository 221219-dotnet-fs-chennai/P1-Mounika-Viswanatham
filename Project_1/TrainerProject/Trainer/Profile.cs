﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trainer
{
    class Profile : IMenu
    {

        Trainerdata newTrainer = new Trainerdata();
      public  Profile(Trainerdata tdata)
        {
            newTrainer = tdata;
        }

        public void Display()
        {
            //throw new NotImplementedException();
            Console.WriteLine("-------------Welcome " + newTrainer.Name + "-----------------\n");
            Console.WriteLine("[0] Go back");
            Console.WriteLine("[1] Show Details");
            

        }

        public string UserChoice()
        {
            //throw new NotImplementedException();

            string userchoice = Console.ReadLine();
            switch(userchoice)
            {
                case "0":
                    
                    return "Menu";

                case "1":

                    showDetails();
                    return "Profile";

                default:
                    return "Profile";
            }



        }

        public void showDetails()
        {
            Console.WriteLine(" EmailId :  " + newTrainer.EmailID);
            Console.WriteLine(" Name :   " + newTrainer.Name);
            Console.WriteLine(" Age :  " + newTrainer.Age);
            Console.WriteLine(" Gender  :   " + newTrainer.Gender);
            Console.WriteLine(" Phone Number :  " + newTrainer.PhoneNumber);
            Console.WriteLine(" Password :  " + newTrainer.Password);
            Console.WriteLine(" Location :  " + newTrainer.Location);
            Console.WriteLine(" Institution Name :  " + newTrainer.institutionName);
            Console.WriteLine(" Degree :  " + newTrainer.Degree);
            Console.WriteLine(" Specialization:  " + newTrainer.Specialization);
            Console.WriteLine(" PassingYear : " + newTrainer.PassingYear);
            Console.WriteLine(" Skill1 : " + newTrainer.Skill1);
            Console.WriteLine(" Skill2 : " + newTrainer.Skill2);
            Console.WriteLine(" Skill3 : " + newTrainer.Skill3);
            Console.WriteLine(" CompanyName :  " + newTrainer.CompanyName);
            Console.WriteLine(" Experience : " + newTrainer.Experience);
            Console.WriteLine(" Position : " + newTrainer.Position);
        }
    }
}