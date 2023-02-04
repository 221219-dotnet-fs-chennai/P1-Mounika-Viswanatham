using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Bussiness
{
    public  interface IBusiness
    {
        IEnumerable<Trainerdata> GetTrainerDisconnected();


        IEnumerable<Trainerdata> FindTrainerByEmail(string EmailID);

        IEnumerable<Trainerdata> FindTrainerByLocation(string Location);

        IEnumerable<Trainerdata> RemoveTrainerByName(string Name);

        //IEnumerable<CompanyDetails> FindTrainerByExperience(string Experience);

        //void TrainerUpdate(string? newData, string? columnName, string? tableName, string? userId);

        //void TrainerDelete(string? columnName, string? tableName, string? userId);
        //IEnumerable<Trainerdata> FindTrainerByLocation();
    }
}
