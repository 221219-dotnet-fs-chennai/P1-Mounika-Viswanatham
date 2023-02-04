using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI;
using FluentAPI.Entities;
using Models;

namespace BusinessLogic
{
    public  class Logic:ILogic    
    {
        IModel<FluentAPI.Entities.TrainerDetail> _repo;
        public Logic(IModel<FluentAPI.Entities.TrainerDetail> repo)
        {
            _repo = repo;
        }

        public Trainerdata AddTrainer(Trainerdata trainerdata)
        {
            //throw new NotImplementedException();
            return Mapper.TrainerMap(_repo.AddTrainer(Mapper.TrainerMap(trainerdata)));
        }

        public IEnumerable<Trainerdata> AllTrainerData()
        {
            // throw new NotImplementedException();
            return Mapper.TrainerMap(_repo.AllTrainerData());
        }

        public IEnumerable<Trainerdata> FindTrainerByEmailID(string EmailID)
        {
            // throw new NotImplementedException();
            var tara = _repo.AllTrainerData().Where(i => i.EmailId == EmailID);
            return Mapper.TrainerMap(tara);
        }


        public IEnumerable<Trainerdata> FindTrainerByLocation(string Location)
        {
            // throw new NotImplementedException();
            var tara = _repo.AllTrainerData().Where(i => i.Location == Location);
            return Mapper.TrainerMap(tara);
        }

        public Trainerdata UpdateTrainer(string Name,Trainerdata trainerdata)
        {
            var tara = (from r in _repo.AllTrainerData()
                        where r.Name == Name &&
                        r.UserId == trainerdata.user_id
                        select r).FirstOrDefault();
            if(tara!=null)
            {
                tara.Name = trainerdata.Name;
                tara.Age = Convert.ToInt32(trainerdata.Age);
                tara.PhoneNumber = trainerdata.PhoneNumber;
                tara.Gender = trainerdata.Gender;
                tara.EmailId = trainerdata.EmailID;
                tara.Password = trainerdata.Password;
                tara.Location = trainerdata.Location;

                tara = _repo.UpdateTrainer(tara);

            }

            return Mapper.TrainerMap(tara);
        }
    }
}
