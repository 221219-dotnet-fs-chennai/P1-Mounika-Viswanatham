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
using System.Security.Cryptography;

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
        public Trainerdata UpdateTrainer(string Email, Trainerdata trainerdata)
        {
            var tara = (from r in _repo.AllTrainerData()
                        where r.EmailId == Email &&
                        r.EmailId == trainerdata.EmailID
                        select r).FirstOrDefault();
            if ( tara!= null)
            {
                tara.Name           = trainerdata.Name;
                tara.Age            = Convert.ToInt32(trainerdata.Age);
                tara.PhoneNumber    = trainerdata.PhoneNumber;
                tara.Gender         = trainerdata.Gender;
                tara.EmailId       = trainerdata.EmailID;
                tara.Password       = trainerdata.Password;
                tara.Location       = trainerdata.Location;

                tara = _repo.UpdateTrainer(tara);

            }

            return Mapper.TrainerMap(tara);
        }

        public Edetail UpdateEducation(string EmailID, Edetail education)
        {
            var tara = (from r in _repo.AllTrainerData()
                        where r.EmailId == EmailID
                        
                        select r).FirstOrDefault();

            string id = tara.UserId;

            var ok = (from r in _eduRepo.GetAllEducation() where r.UserId == id select r).FirstOrDefault();

            if (ok != null)
            {
                ok.PassingYear        = education.PassingYear;
                ok.InstitutionName    = education.institutionName;
                ok.Specialization     = education.Specialization;
                ok.Degree             = education.Degree;

                ok = _eduRepo.UpdateEducation(ok);

            }

            return Mapper.EducationMap(ok);
        }

        public cdetail UpdateCompany(string EmailID,  cdetail s)
        {
            var tara = (from r in _repo.AllTrainerData()
                        where r.EmailId == EmailID

                        select r).FirstOrDefault();

            string id = tara.UserId;

            var ok = (from r in _com.GetAllCompany() where r.UserId == id select r).FirstOrDefault(); 
            if (ok != null)
            {
                ok.CompanyName    = s.CompanyName;
                ok.Experience     =s.Experience;

                ok = _com.UpdateCompany(ok);

            }

            return Mapper.CompanyMap(ok);
        }

        public Sdetail UpdateSkill(string email, Sdetail s)
        {
            //throw new NotImplementedException();
            var tara = (from r in _repo.AllTrainerData()
                        where r.EmailId == email

                        select r).FirstOrDefault();

            string id= tara.UserId;

            var ok = (from r in _skil.GetAllSkills() where r.UserId == id select r).FirstOrDefault();
            if (ok != null)
            {
                ok.Skill1 = s.Skill1;
                ok.Skill2 = s.Skill2;
                ok.Skill3 = s.Skill3;

                ok = _skil.UpdateSkill(ok);


            }
            return Mapper.SkillMap(ok);


        }

        public Edetail updateEducation(string EmailID,Edetail e)
        {
            var ok =  (from r in _repo.AllTrainerData()
                                 where r.EmailId == EmailID

                                 select r).FirstOrDefault();

            string id = ok.UserId;
            var tara = (from r in _eduRepo.GetAllEducation() where r.UserId == id select r).FirstOrDefault();


            if (tara!=null)
            {
                tara.InstitutionName    = e.institutionName;
                tara.Degree             = e.Degree;
                tara.Specialization     = e.Specialization;
                tara.PassingYear        = e.PassingYear;

                tara = _eduRepo.UpdateEducation(tara);
            }

            return Mapper.EducationMap(tara);
                
        }
        public Trainerdata DeleteTrainer(string EmailID)
        {
            var tara = _repo.DeleteTr(EmailID);
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

        public IEnumerable<Edetail> GetAllEducation()
        {
            return Mapper.EducationMap(_eduRepo.GetAllEducation());
        }
        public bool Login(string EmailID, string Password)
        {
            //throw new NotImplementedException();

            return _repo.Login(EmailID, Password);
        }

      
    }
}
