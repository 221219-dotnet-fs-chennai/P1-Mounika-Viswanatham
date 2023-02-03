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
        public static Model.Trainerdata Map(Data1.TrainerDetail r)
        {
            return new Model.Trainerdata()
            {

                Name = r.Name,
                Gender = r.Gender,
                PhoneNumber = r.PhoneNumber,
                EmailID = r.EmailId,
                Age = Convert.ToString(r.Age),
                Location = r.Location,
               // Password= r.Password,
               //institutionName=r.EducationDetail.institutionName,
               Degree=r.EducationDetail.Degree,
               
                
            };



        }
        public static Model.Trainerdata Map(Data1.EducationDetail s)
        {
            return new Model.Trainerdata()
            {
                institutionName = s.InstitutionName,
                Degree = s.Degree,
                PassingYear = s.PassingYear,
                Specialization = s.Specialization,
            };

        }

        public static Model.Trainerdata Map(Data1.CompanyDetail c)
        {
            return new Model.Trainerdata()
            {
                CompanyName = c.CompanyName,
                Experience = c.Experience,
            };
        }

        public static Model.Trainerdata Map(Data1.SkillsDetail s)
        {
            return new Model.Trainerdata()
            {
                Skill1= s.Skill1,
                Skill2= s.Skill2,
                Skill3= s.Skill3,

            };
        }

        public static IEnumerable<Model.Trainerdata> Map(IEnumerable<Data1.TrainerDetail> trainers)
        {
            return trainers.Select(Map);
        }
        public static IEnumerable<Model.Trainerdata> Map(IEnumerable<Data1.SkillsDetail> trainers)
        {
            return trainers.Select(Map);
        }

        public static IEnumerable<Model.Trainerdata> Map(IEnumerable<Data1.EducationDetail> trainers)
        {
            return trainers.Select(Map);
        }
        public static IEnumerable<Model.Trainerdata> Map(IEnumerable<Data1.CompanyDetail> trainers)
        {
            return trainers.Select(Map);
        }
    }

}
