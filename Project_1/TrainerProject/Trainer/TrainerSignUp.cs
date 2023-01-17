using Data;
namespace Trainer
{
    internal class TrainerSignUp : IMenu
    { 
        
        private static Trainerdata newTrainer = new Trainerdata();
    
        public void Display()
        {
            
                Console.WriteLine("\n Enter Information ");
                Console.WriteLine("[0] Menu  ");
                Console.WriteLine("[1] EmailId :  " + newTrainer.EmailID);
                Console.WriteLine("[2] Name :   " + newTrainer.Name);
                Console.WriteLine("[3] Age :  " + newTrainer.Age);
                Console.WriteLine("[4] Gender  :   " + newTrainer.Gender);
                Console.WriteLine("[5] Phone Number :  " + newTrainer.PhoneNumber);
                Console.WriteLine("[6] Location :  " + newTrainer.Location);
                Console.WriteLine("[7] WebsiteLink :  " + newTrainer.WebsiteLink);
                Console.WriteLine("[8] Institution Name :  " + newTrainer.InstitutionName);
                Console.WriteLine("[9] Degree :  " + newTrainer.Degree);
                Console.WriteLine("[10] Specialization:  " + newTrainer.Specialization);
                Console.WriteLine("[11] CGPA :  " + newTrainer.CGPA);
                Console.WriteLine("[12] PassingYear : " + newTrainer.PassingYear);
                Console.WriteLine("[13] Skill1 : " + newTrainer.Skill1);
                Console.WriteLine("[14] Skill2 : " + newTrainer.Skill2);
                Console.WriteLine("[15] Skill3 : " + newTrainer.Skill3);
                Console.WriteLine("[16] CompanyName :  " + newTrainer.CompanyName);
                Console.WriteLine("[17] Experience : " + newTrainer.Experience);
                Console.WriteLine("[18] Position : " + newTrainer.Position);


        }
        public string UserChoice()
        {
            Console.WriteLine("Collecting Information");
            Console.WriteLine("Enter your choice");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    Console.WriteLine("Enter EmailID :  ");
                    newTrainer.EmailID = Console.ReadLine();
                    return "Signup";
                case "2":
                    Console.WriteLine("Enter Name :  ");
                    newTrainer.Name = Console.ReadLine();
                    return "Signup";
                case "3":
                    Console.WriteLine("Enter Age :  ");
                    newTrainer.Age = Console.ReadLine();
                    return "Signup";
                case "4":
                    Console.WriteLine("Enter Gender :  ");
                    newTrainer.Gender = Console.ReadLine();
                    return "Signup";
                case "5":
                    Console.WriteLine("Enter PhoneNumber :  ");
                    newTrainer.PhoneNumber = Console.ReadLine();
                    return "Signup";
                case "6":
                    Console.WriteLine("Enter Location :  ");
                    newTrainer.Location = Console.ReadLine();
                    return "Signup";
                case "7":
                    Console.WriteLine("Enter WebsiteLink :  ");
                    newTrainer.WebsiteLink = Console.ReadLine();
                    return "Signup";
                case "8":
                    Console.WriteLine("Enter Institution Name :  ");
                    newTrainer.InstitutionName = Console.ReadLine();
                    return "Signup";
                case "9":
                    Console.WriteLine("Enter Degree :  ");
                    newTrainer.Degree = Console.ReadLine();
                    return "Signup";
                case "10":
                    Console.WriteLine("Enter Specialization :  ");
                    newTrainer.Specialization = Console.ReadLine();
                    return "Signup";
                case "11":
                    Console.WriteLine("Enter CGPA :  ");
                    newTrainer.CGPA = Console.ReadLine();
                    return "SignUp";
                case "12":
                    Console.WriteLine("Enter PassingYear :  ");
                    newTrainer.PassingYear = Console.ReadLine();
                    return "Signup";
                case "13":
                    Console.WriteLine("Enter Skill1 :  ");
                    newTrainer.Skill1 = Console.ReadLine();
                    return "Signup";
                case "14":
                    Console.WriteLine("Enter Skill2 :  ");
                    newTrainer.Skill2 = Console.ReadLine();
                    return "Signup";
                case "15":
                    Console.WriteLine("Enter SKill3 :  ");
                    newTrainer.Skill3 = Console.ReadLine();
                    return "Signup";
                case "16":
                    Console.WriteLine("Enter CompanyName :  ");
                    newTrainer.CompanyName = Console.ReadLine();
                    return "Signup";
                case "17":
                    Console.WriteLine("Enter Experience :  ");
                    newTrainer.Experience = Console.ReadLine();
                    return "Signup";
                case "18":
                    Console.WriteLine("Enter YOur Position in Company :  ");
                    newTrainer.Position = Console.ReadLine();
                    return "Signup";
                default:
                    Console.WriteLine("please input a valid respone");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "Signup";

            }


        }         
        
                
     }


}

