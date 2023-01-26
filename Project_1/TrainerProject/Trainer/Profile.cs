using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Trainer
{
    class Profile : IMenu
    {
        static string constr = File.ReadAllText("../../../connectionString.txt");
        IRepo repo = new SqlRepo(constr);

        Trainerdata newTrainer = new Trainerdata();
        public Profile(Trainerdata tdata)
        {
            newTrainer = tdata;
        }

        public void Display()
        {
            Log.Logger.Information("Welcome " + newTrainer.Name + "\n");
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
            switch (userchoice)
            {
                case "0":

                    return "Menu";

                case "1":

                    return "showTrainerData";
                case "2":

                    var AllTrainersData = repo.GetTrainerDisconnected();
                    foreach(var i in AllTrainersData)
                    {
                        //Console.WriteLine(i.ToString());
                        Console.WriteLine(i.AllTrainerData() + "\n");
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


    }
}
