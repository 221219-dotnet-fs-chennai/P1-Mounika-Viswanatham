using Model;
using Data;

namespace Bussiness
{
    public class Class1 : IBusiness
    {
        IRepo repo;
        public Class1(string conStr)
        {
            repo = new SqlRepo(conStr);

        }
        public Trainerdata FindTrainerByEmail()
        {
            //throw new NotImplementedException();
           return  repo.FindTrainerByEmail();
        }

        public IEnumerable<Trainerdata> FindTrainerByLocation()
        {
            //throw new NotImplementedException();
            return repo.FindTrainerByLocation();
        }

        public IEnumerable<Trainerdata> GetTrainerDisconnected()
        {
            // throw new NotImplementedException();
            return repo.GetTrainerDisconnected();
        }
    }
}