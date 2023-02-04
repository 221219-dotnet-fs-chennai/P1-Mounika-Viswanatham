using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public interface IRepo<T>
    {
        T Add(T trainerdata);

       /* List<Trainerdata> GetTrainerdatas();*/

        List<T> GetTrainerDisconnected();

        /*T GetATrainer(string EmailID);

        bool Login(string email);

       void TrainerUpdate(string? newData, string? columnName, string? tableName, string? userId);

       void TrainerDelete(string? columnName,string? tableName,string? userId);

        T FindTrainerByEmail();*/

        //Trainerdata FindTrainerByLocation(string Location);

       List<T> FindTrainerByLocation();

       // List<T> RemoveTrainerByName(string Name);

       
    }
}
