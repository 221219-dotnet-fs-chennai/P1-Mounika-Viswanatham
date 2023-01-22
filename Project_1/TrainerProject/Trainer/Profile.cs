using Data;
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
            Console.WriteLine("-------------Welcome " + newTrainer.Name + "-----------------\n");
            Console.WriteLine("[0] LogOut");
            Console.WriteLine("[1] Show Details");
            Console.WriteLine("[2] Get All Trainers Data");
            Console.WriteLine("[3] Update Details");
            Console.WriteLine("[4] Delete Details");
             

        }

        public string UserChoice()
        {
            
            string userchoice = Console.ReadLine();
            switch(userchoice)
            {
                case "0":
                    
                    return "Menu";

                case "1":
                    Console.WriteLine("[0] Go Back ");
                    Console.WriteLine("[1] Show Personal Details");
                    Console.WriteLine("[2] Show Eductaional Details");
                    Console.WriteLine("[3] Show Skills Details");
                    Console.WriteLine("[4] Show Compnay Details");

                    string choice= Console.ReadLine();
                  
                    if (choice == "1")
                    {
                        showDetails(1);
                    }
                    if(choice == "2")
                    {
                        showDetails(2);
                    }
                    if(choice =="3")
                    {
                        showDetails(3);
                    }
                    if(choice == "4")
                    {
                            showDetails(4);
                    }
                    return "Profile";
                   
                case "3":

                    return "TrainerUpdate";

                case "4":

                    return "TrainerDelete";

                default:

                    return "Profile";


            }



        }

        public void showDetails(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("   --------Showing PERSONAL Details --------\n   ");
                Console.WriteLine(" EmailId        :   " + newTrainer.EmailID);
                Console.WriteLine(" Name           :   " + newTrainer.Name);
                Console.WriteLine(" Age            :   " + newTrainer.Age);
                Console.WriteLine(" Gender         :   " + newTrainer.Gender);
                Console.WriteLine(" Phone Number   :   " + newTrainer.PhoneNumber);
                Console.WriteLine(" Password       :   " + newTrainer.Password);
                Console.WriteLine(" Location       :   " + newTrainer.Location);
            }
            if (i == 2)
            {
                Console.WriteLine("   --------Showing EDUCATIONAL Details --------\n   ");
                Console.WriteLine(" Institution Name    :  " + newTrainer.institutionName);
                Console.WriteLine(" Degree              :  " + newTrainer.Degree);
                Console.WriteLine(" Specialization      :  " + newTrainer.Specialization);
                Console.WriteLine(" PassingYear         : " + newTrainer.PassingYear);
            }
            if (i == 3)
            {
                Console.WriteLine("   --------Showing SKILLS Details --------\n   ");
                Console.WriteLine(" Skill1     : " + newTrainer.Skill1);
                Console.WriteLine(" Skill2     : " + newTrainer.Skill2);
                Console.WriteLine(" Skill3     : " + newTrainer.Skill3);
            }
            if (i == 4)
            {
                Console.WriteLine("   --------Showing COMPANY Details --------\n   ");
                Console.WriteLine(" CompanyName     :  " + newTrainer.CompanyName);
                Console.WriteLine(" Experience      : " + newTrainer.Experience);
            }
           // Console.WriteLine(" Position : " + newTrainer.Position);
        }
    }
}
