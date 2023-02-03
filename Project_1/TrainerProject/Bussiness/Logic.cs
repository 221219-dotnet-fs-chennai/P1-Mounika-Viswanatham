using Model;
using FluentAPI.Entities;

namespace Bussiness
{
    public class Logic : IBusiness
    {
        IRepo<FluentAPI.Entities.TrainerDetail> repo;
        public Logic(IRepo<FluentAPI.Entities.TrainerDetail> r)
        {
           // repo = new SqlRepo(conStr);
           repo =  r;
        }
        public Trainerdata FindTrainerByEmail()
        {
            throw new NotImplementedException();
            //return Mapper.Map(repo.FindTrainerByEmail());
        }

        public IEnumerable<Trainerdata> FindTrainerByLocation()
        {
            //throw new NotImplementedException();

            var rest = new TrainerDetail();
            var data = repo.FindTrainerByLocation();
            foreach(var item in data)
            {
                rest.Name= item.Name;

            }

            return Mapper.Map(data);
            
        }

        public IEnumerable<Trainerdata> GetTrainerDisconnected()
        {
            // throw new NotImplementedException();
            return Mapper.Map(repo.GetTrainerDisconnected());
        }

        
    }
}