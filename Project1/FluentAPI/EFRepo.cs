﻿using Models;
using FluentAPI.Entities;

namespace FluentAPI
{
    public class EFRepo:IModel<Entities.TrainerDetail>
    {
        private readonly TrainerdatabaseContext _context;
        public EFRepo(TrainerdatabaseContext context)
        {
            _context= context;
        }

        public TrainerDetail AddTrainer(TrainerDetail trainer)
        {
            //throw new NotImplementedException();
            _context.Add(trainer);
            _context.SaveChanges();

            return trainer;
        }

        public List<Entities.TrainerDetail> AllTrainerData()
        {
            //throw new NotImplementedException();
           // var sera=_context.TrainerDetails.Where(T=>)
            return _context.TrainerDetails.ToList();
        }
        public IEnumerable<Entities.TrainerDetail>FindTrainerByEmailID()
        {
            return _context.TrainerDetails.ToList();
        }

        public IEnumerable<Entities.TrainerDetail> FindTrainerByLocation()
        {
            return _context.TrainerDetails.ToList();
        }

        public TrainerDetail UpdateTrainer(TrainerDetail trainerdata)
        {
            //throw new NotImplementedException();
            _context.TrainerDetails.Update(trainerdata);
            _context.SaveChanges();
            return trainerdata;
        }
        public Entities.TrainerDetail DeleteTr(string Name)
        {
            var sera = _context.TrainerDetails.Where(T => T.Name == Name).FirstOrDefault();
            if(sera!=null)
            {
                _context.TrainerDetails.Remove(sera);
                _context.SaveChanges();
            }

            return sera;
        }


        public IEnumerable<GetAllData> getAllTrainerdatas()
        {
            var td = _context.TrainerDetails;
            var ed = _context.EducationDetails;
            var sd = _context.SkillsDetails;
            var cd = _context.CompanyDetails;

            var getalltrainer = (from t in td
                              join e in ed on t.UserId equals e.UserId
                              join s in sd on e.UserId equals s.UserId
                              join c in cd on s.UserId equals c.UserId
                              select new GetAllData()
                              {
                                  EmailID = t.EmailId,
                                  Name=t.Name,
                                  Age = Convert.ToString(t.Age),
                                  Gender = t.Gender,
                                  PhoneNumber = t.PhoneNumber,
                                  institutionName=e.InstitutionName,
                                  Degree=e.Degree,
                                  Specialization=e.Specialization,
                                  PassingYear=e.PassingYear,
                                  Skill1=s.Skill1,
                                  Skill2=s.Skill2,
                                  Skill3=s.Skill3,
                                  CompanyName=c.CompanyName,
                                  Experience=c.Experience,

                              });
            return getalltrainer.ToList();
        }

        
    }
}