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
            Log.Logger.Information("Find trainer by location  called");
            var tara = _repo.AllTrainerData().Where(i => i.Location == Location);
            return Mapper.TrainerMap(tara);
        }

        public IEnumerable<cdetail> FindTrainerByExperience(string Eexperience) {
            Log.Logger.Information("Find trainer by experience called");
            var  tara=_com.GetAllCompany().Where(i=>i.Experience == Eexperience);
            return Mapper.CompanyMap(tara);
        }
        public IEnumerable<Sdetail> FindTrainerBySkill(string SkillName)
        {
            Log.Logger.Information("Find trainer by Skills called");
            var tara = _skil.GetAllSkills().Where(i => i.Skill1 == SkillName || i.Skill2 == SkillName || i.Skill3 == SkillName);
                return Mapper.SkillMap(tara);
        }
        public Trainerdata UpdateTrainer(string Email, Trainerdata trainerdata)
        {
            Log.Logger.Information("update trainer called");
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
                tara.EmailId       
                    = trainerdata.EmailID;
                tara.Password       = trainerdata.Password;
                tara.Location       = trainerdata.Location;

                tara = _repo.UpdateTrainer(tara);

            }

            return Mapper.TrainerMap(tara);
        }

        public Edetail UpdateEducation(string EmailID, Edetail education)
        {
            Log.Logger.Information("update education called");
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
            Log.Logger.Information("update company called");
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
            Log.Logger.Information("Update Skills called");
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
            Log.Logger.Information("Update Education called");
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
            Log.Logger.Information("Delete trainer called");
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
            Log.Logger.Information("Get All Trainer Data called");
            //throw new NotImplementedException();
            return _repo.getAllTrainerdatas();
        }

       public IEnumerable<Sdetail> GetAllSkills()
        {
            Log.Logger.Information("Get All Skills called");
            return Mapper.SkillMap(_skil.GetAllSkills());
        }
        public IEnumerable<cdetail> GetAllCompany()
        {
            Log.Logger.Information("Get All Company called");
            return Mapper.CompanyMap(_com.GetAllCompany());
        }

        public IEnumerable<Edetail> GetAllEducation()
        {
            Log.Logger.Information("Get All Education called");
            return Mapper.EducationMap(_eduRepo.GetAllEducation());
        }
        public bool Login(string EmailID, string Password)
        {
            //throw new NotImplementedException();
            Log.Logger.Information("Login called");

            return _repo.Login(EmailID, Password);
        }

        public Edetail GetEducationById(string id)
        {
            //throw new NotImplementedException();
            var r=_eduRepo.GetAllEducation().Where(i=>i.UserId== id).FirstOrDefault();
            return Mapper.EducationMap(r);
        }

        public Sdetail GetSkillById(string id)
        {
            //throw new NotImplementedException();
            var r=_skil.GetAllSkills().Where(i=>i.UserId== id).FirstOrDefault();
            return Mapper.SkillMap(r);
        }

        public GetAllData GetTrainer(string EmailID)
        {
            //throw new NotImplementedException();
            var r=_repo.getAllTrainerdatas().Where(i=>i.EmailID== EmailID).FirstOrDefault();
            return r;
        }

        public cdetail GetCompanyByID(string id)
        {
            //throw new NotImplementedException();
            var r=_com.GetAllCompany().Where(i=>i.UserId== id).FirstOrDefault();
            return Mapper.CompanyMap(r);
        }
    }
}
