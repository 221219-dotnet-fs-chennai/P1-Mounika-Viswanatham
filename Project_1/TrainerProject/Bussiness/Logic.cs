using Model;
using FluentAPI.Entities;
using FluentAPI;
using Microsoft.EntityFrameworkCore;

namespace Bussiness
{
    public class Logic : IBusiness
    {
        IRepo<FluentAPI.Entities.TrainerDetail> repo;
        
        public Logic(IRepo<FluentAPI.Entities.TrainerDetail> r)
        {
            // repo = new SqlRepo(conStr);
            repo = r;
        }
        public IEnumerable<Trainerdata> FindTrainerByEmail(string EMailID)
        {
            var ser=repo.GetTrainerDisconnected().Where (r=>r.EmailId==EMailID);
            return Mapper.TrainerMap(ser);
        }

        public IEnumerable<Trainerdata> FindTrainerByLocation(string Location)
        {
            
            var se = repo.GetTrainerDisconnected().Where(r => r.Location == Location);

            return Mapper.TrainerMap(se);

        }

       
        /*public CompanyDetails FindTrainerByExperience(string Experience)
        {

            var se = repo.GetTrainerDisconnected().Where(r => r.Experience == Experience);

            return Mapper.TrainerMap(se);

        }*/

        public IEnumerable<Trainerdata> GetTrainerDisconnected()
        {
            // throw new NotImplementedException();
            return Mapper.TrainerMap(repo.GetTrainerDisconnected());
            
        }

        
    }
}

