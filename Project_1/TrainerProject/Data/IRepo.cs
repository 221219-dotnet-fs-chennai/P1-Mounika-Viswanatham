using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public interface IRepo
    {
        Trainerdata Add(Trainerdata trainerdata);

       /* List<Trainerdata> GetTrainerdatas();*/

        List<Trainerdata> GetTrainerDisconnected();

        Trainerdata GetATrainer(string EmailID);

        bool Login(string email);

       void TrainerUpdate(string? newData, string? columnName, string? tableName, string? userId);

       void TrainerDelete(string? columnName,string? tableName,string? userId);

        Trainerdata FindTrainerByEmail();

        //Trainerdata FindTrainerByLocation(string Location);

       List<Trainerdata> FindTrainerByLocation();

       
    }
}
