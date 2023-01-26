using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Bussiness;
namespace Trainer
{
    internal class FindTrainerByEmail  : IMenu
    {
        static string conStr = File.ReadAllText("../../../connectionString.txt");
       // IRepo repo = new SqlRepo(conStr);

        IBusiness repo=new Logic(conStr);

        public void Display()
        {
            //throw new NotImplementedException();
            Console.WriteLine("******************* SEARCH TRAINER *************************\n");
            Console.WriteLine("Enter the choice you want");
            Console.WriteLine("[0] go back  ");
            Console.WriteLine("[1] Find Trainer\n");
        }

        public string UserChoice()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Enter your choice");
            string choice=Console.ReadLine();
            Console.WriteLine("\n");
            switch(choice)
            {
                case "0":
                    return "Menu";
                case "1":
                   var s= repo.FindTrainerByEmail();
                    
                    Console.WriteLine("---- Trainer Details----\n");
                    Console.WriteLine("Name         : "  + s.Name);
                    Console.WriteLine("EmailId      : "  + s.EmailID);
                    Console.WriteLine("PhoneNumber  : "  + s.PhoneNumber);
                    Console.WriteLine("Location     : "  + s.Location);
                    Console.WriteLine("Gender       : "  + s.Gender);
                    Console.WriteLine("\n");
                    Console.WriteLine("----Trainer Skills----\n");
                    Console.WriteLine("Skill1       : " + s.Skill1);
                    Console.WriteLine("Skill2       : " + s.Skill2);
                    Console.WriteLine("Skill3       : " + s.Skill3);
                    Console.WriteLine();

                    /*foreach(var i in s)
                    {
                        Console.WriteLine(i.AllTrainerData());
                    }*/
                    Console.ReadLine();
                    return "FindTrainerByEmail";
            }
            return "Menu";
        }
    }
}
