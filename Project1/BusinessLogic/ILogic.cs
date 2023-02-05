using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public interface  ILogic
    {
        IEnumerable<Trainerdata> AllTrainerData();

       Trainerdata AddTrainer(Trainerdata trainerdata);

        
        IEnumerable<Trainerdata> FindTrainerByEmailID(string EmailID);

        IEnumerable<Trainerdata> FindTrainerByLocation(string Location);

        Trainerdata UpdateTrainer(string Name,Trainerdata trainerdata);

        Trainerdata DeleteTrainer(string Name);


        

    }
}
