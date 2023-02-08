global using Serilog;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI;
using FluentAPI.Entities;
using Models;
using System.Net;

namespace BusinessLogic
{
    public class Logic : ILogic
    {
        IModel<FluentAPI.Entities.TrainerDetail> _repo;
        IEduRepo<FluentAPI.Entities.EducationDetail> _eduRepo;
        ICompany<FluentAPI.Entities.CompanyDetail> _com;
        ISkill<FluentAPI.Entities.SkillsDetail> _skil;
        //IModel<FluentAPI.Entities.SkillsDetail> _see;

        

        public Logic(IModel<FluentAPI.Entities.TrainerDetail> repo,IEduRepo<FluentAPI.Entities.EducationDetail> erepo,ICompany<FluentAPI.Entities.CompanyDetail> crepo,ISkill<FluentAPI.Entities.SkillsDetail> srepo)
        {
            _repo = repo;
            _eduRepo = erepo;
            _com= crepo;
            _skil= srepo;
            
        }

        public Trainerdata AddTrainer(Trainerdata trainerdata)
        {
            //throw new NotImplementedException();
            return Mapper.TrainerMap(_repo.AddTrainer(Mapper.TrainerMap(trainerdata)));
        }

        public Edetail AddTrainerEducation(Edetail e)
        {
            return Mapper.EducationMap(_eduRepo.AddTrainerEducation(Mapper.EducationMap(e)));
        }

        public cdetail AddTrainerCompany(cdetail c)
        {
            return Mapper.CompanyMap(_com.AddTrainerCompany(Mapper.CompanyMap(c)));
        }

         public Sdetail AddTrainerSkill(Sdetail s)
        {
            return Mapper.SkillMap(_skil.AddTrainerSkill(Mapper.SkillMap(s)));
        }
        public IEnumerable<Trainerdata> AllTrainerData()
        {
            
            return Mapper.TrainerMap(_repo.AllTrainerData());
        }

        public IEnumerable<Trainerdata> FindTrainerByEmailID(string EmailID)
        {
            // throw new NotImplementedException();
            Log.Logger.Information("TrainerByEmailID");
            var tara = _repo.AllTrainerData().Where(i => i.EmailId == EmailID);
            return Mapper.TrainerMap(tara);
        }


        public IEnumerable<Trainerdata> FindTrainerByLocation(string Location)
        {
            // throw new NotImplementedException();
            var tara = _repo.AllTrainerData().Where(i => i.Location == Location);
            return Mapper.TrainerMap(tara);
        }

        public IEnumerable<cdetail> FindTrainerByExperience(string Eexperience) {

            var  tara=_com.GetAllCompany().Where(i=>i.Experience == Eexperience);
            return Mapper.CompanyMap(tara);
        }
        public IEnumerable<Sdetail> FindTrainerBySkill(string SkillName)
        {
            var tara = _skil.GetAllSkills().Where(i => i.Skill1 == SkillName || i.Skill2 == SkillName || i.Skill3 == SkillName);
                return Mapper.SkillMap(tara);
        }
        public Trainerdata UpdateTrainer(string Name, Trainerdata trainerdata)
        {
            var tara = (from r in _repo.AllTrainerData()
                        where r.Name == Name &&
                        r.UserId == trainerdata.user_id
                        select r).FirstOrDefault();
            if (tara != null)
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

        /* public Edetail UpdateEducation(string user_id, Edetail education)
         {
             var tara = (from r in _eduRepo.()
                         where r.UserId == user_id &&
                         r.UserId == education.user_id
                         select r).FirstOrDefault();
             if (tara != null)
             {
                 tara.PassingYear = education.PassingYear;
                 tara.institutionName = education.institutionName;
                 tara.Specialization = education.Specialization;
                 tara.Degree = education.Degree;

                 tara = _eduRepo.UpdateEducation(tara);

             }

             return Mapper.EducationMap(tara);
         }*/

         public cdetail UpdateCompany(string user_id,  cdetail s)
        {
            var tara = (from r in _com.GetAllCompany()
                        where r.UserId == user_id &&
                        r.UserId == s.user_id
                        select r).FirstOrDefault();
            if (tara != null)
            {
                tara.CompanyName= s.CompanyName;
                tara.Experience=s.Experience;

                tara = _com.UpdateCompany(tara);

            }

            return Mapper.CompanyMap(tara);
        }

        public Sdetail UpdateSkill(string user_id, Sdetail s)
        {
            //throw new NotImplementedException();

            var tara = (from t in _skil.GetAllSkills()
                        where t.UserId == user_id 
                        //t.UserId == s.user_id
                        select t
                        ).FirstOrDefault();
            if (tara != null)
            {
                tara.Skill1 = s.Skill1;
                tara.Skill2 = s.Skill2;
                tara.Skill3 = s.Skill3;

                tara = _skil.UpdateSkill(tara);


            }
            return Mapper.SkillMap(tara);


        }
        public Trainerdata DeleteTrainer(string Name)
        {
            var tara = _repo.DeleteTr(Name);
            if (tara != null)
            {
                return Mapper.TrainerMap(tara);
            }
            else
            {
                return null;
            }



        }

        public IEnumerable<GetAllData> getAllTrainerdatas()
        {
            //throw new NotImplementedException();
            return _repo.getAllTrainerdatas();
        }

       public IEnumerable<Sdetail> GetAllSkills()
        {
            return Mapper.SkillMap(_skil.GetAllSkills());
        }
        public IEnumerable<cdetail> GetAllCompany()
        {
            return Mapper.CompanyMap(_com.GetAllCompany());
        }
        public bool Login(string EmailID, string Password)
        {
            //throw new NotImplementedException();

            return _repo.Login(EmailID, Password);
        }

      
    }
}
