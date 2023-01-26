//using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Bussiness;
namespace Trainer
{
    internal class FindTrainerByLocation : IMenu
    {
        static string conStr = File.ReadAllText("../../../connectionString.txt");
        IBusiness repo = new Class1(conStr);

        public void Display()
        {
            //throw new NotImplementedException();
            Console.WriteLine("******************** Search Trainer **********************\n");
            Console.WriteLine("Enter the choice you want");
            Console.WriteLine("[0] go back  ");
            Console.WriteLine("[1] Find Trainer By Location\n");
        }

        public string UserChoice()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();
            Console.WriteLine("\n");
            switch (choice)
            {
                case "0":
                    return "Menu";
                case "1":
                   
                    var AllTrainersData = repo.FindTrainerByLocation();
                    
                    foreach (var i in AllTrainersData)
                    {
                        //Console.WriteLine(i.ToString());
                        Console.WriteLine("-----Trainer Details-----");
                        Console.WriteLine(i.AllTrainerData() + "\n");
                    }

                    return "FindTrainerByLocation";
                default:
                    Console.WriteLine("Wrong Choice ");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();


                    return "FindTrainerByLocation";
            }
            return "Menu";
        }
    }
}
