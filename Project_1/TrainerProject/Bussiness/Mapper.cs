using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data1 = FluentAPI.Entities;
using Model;

namespace Bussiness
{
    public class Mapper
    {

       // private static FluentAPI.Entities.TrainerdbaseContext context = new Data1.TrainerdbaseContext();
        public static Model.Trainerdata TrainerMap(Data1.TrainerDetail r)
        {
            return new Model.Trainerdata()
            {
                user_id=r.UserId,
                Name = r.Name,
                Gender = r.Gender,
                PhoneNumber = r.PhoneNumber,
                EmailID = r.EmailId,
                Age = Convert.ToString(r.Age),
                Location = r.Location,
               // Password= r.Password,
               //institutionName=r.EducationDetail.institutionName,
              // Degree=r.EducationDetail.Degree,
               
                
            };



        }
        public static Data1.TrainerDetail TrainerMap(Model.Trainerdata r)
        {
            return new Data1.TrainerDetail()
            {

                Name = r.Name,
                Gender = r.Gender,
                PhoneNumber = r.PhoneNumber,
                EmailId = r.EmailID,
                Age = Convert.ToInt32(r.Age),
                Location = r.Location,
                // Password= r.Password,
                //institutionName=r.EducationDetail.institutionName,
                // Degree=r.EducationDetail.Degree,


            };



        }
        public static Model.Education_Detail EducationMap(Data1.EducationDetail s)
        {
            return new Model.Education_Detail()
            {
                user_id = s.UserId,
                institutionName = s.InstitutionName,
                Degree = s.Degree,
                PassingYear = s.PassingYear,
                Specialization = s.Specialization,
            };

        }
        public static Data1.EducationDetail EducationMap(Model.Education_Detail s)
        {
            return new Data1.EducationDetail()
            {
                UserId=s.user_id,
                InstitutionName = s.institutionName,
                Degree = s.Degree,
                PassingYear = s.PassingYear,
                Specialization = s.Specialization,
            };

        }



        public static Model.CompanyDetails CompanyMap(Data1.CompanyDetail c)
        {
            return new Model.CompanyDetails()
            {
                user_id = c.UserId,
                CompanyName = c.CompanyName,
                Experience = c.Experience,
            };
        }

        public static Data1.CompanyDetail CompanyMap(Model.CompanyDetails c)
        {
            return new Data1.CompanyDetail()
            {
                UserId=c.user_id,
                CompanyName = c.CompanyName,
                Experience = c.Experience,
            };
        }

        public static Model.SkillsDetails SkillMap(Data1.SkillsDetail s)
        {
            return new Model.SkillsDetails()
            {
                user_id = s.UserId,
                Skill1 = s.Skill1,
                Skill2= s.Skill2,
                Skill3= s.Skill3,

            };
        }
        public static Data1.SkillsDetail SkillMap(Model.SkillsDetails s)
        {
            return new Data1.SkillsDetail()
            {
                UserId=s.user_id,
                Skill1 = s.Skill1,
                Skill2 = s.Skill2,
                Skill3 = s.Skill3,

            };
        }

        public static IEnumerable<Model.Trainerdata> TrainerMap(IEnumerable<Data1.TrainerDetail> trainers)
        {
            return trainers.Select(TrainerMap);
        }
        public static IEnumerable<Model.SkillsDetails> SkillMap(IEnumerable<Data1.SkillsDetail> trainers)
        {
            return trainers.Select(SkillMap);
        }

        public static IEnumerable<Model.Education_Detail> EducationMap(IEnumerable<Data1.EducationDetail> trainers)
        {
            return trainers.Select(EducationMap);
        }
        public static IEnumerable<Model.CompanyDetails> CompanyMap(IEnumerable<Data1.CompanyDetail> trainers)
        {
            return trainers.Select(CompanyMap);
        }
    }

}
