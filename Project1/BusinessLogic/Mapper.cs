using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI.Entities;
using System.Net.Cache;

namespace BusinessLogic
{
    public class Mapper
    {
        public static Models.Trainerdata  TrainerMap(FluentAPI.Entities.TrainerDetail s)
        {
            return new Models.Trainerdata()
            {

                user_id = s.UserId,
                Name  = s.Name,
                EmailID=s.EmailId,
                PhoneNumber=s.PhoneNumber,
                Gender=s.Gender,
                Age=Convert.ToInt32(s.Age),
                Location=s.Location,


                
            
            };


        }

        public static Models.Edetail EducationMap(FluentAPI.Entities.EducationDetail s)
        {
            return new Models.Edetail()
            {
                user_id = s.UserId,
                institutionName = s.InstitutionName,
                Degree = s.Degree,
                Specialization = s.Specialization,
                PassingYear = s.PassingYear,

            };
        }

        public static Models.cdetail CompanyMap(FluentAPI.Entities.CompanyDetail c)
        {
            return new Models.cdetail()
            {
                user_id= c.UserId,
                CompanyName=c.CompanyName,
                Experience=c.Experience,
            };
        }

        public static Models.Sdetail SkillMap(FluentAPI.Entities.SkillsDetail s)
        {
            return new Models.Sdetail()
            {
                user_id = s.UserId,
                Skill1 = s.Skill1,
                Skill2 = s.Skill2,
                Skill3 = s.Skill3,
            };
        }
        public static FluentAPI.Entities.TrainerDetail TrainerMap(Models.Trainerdata e)
        {
            return new FluentAPI.Entities.TrainerDetail()
            {
                UserId = e.user_id,
                Name = e.Name,
                EmailId = e.EmailID,
                PhoneNumber = e.PhoneNumber,
                Gender = e.Gender,
                Age = Convert.ToInt32(e.Age),
                Location=e.Location,
            };
        }
        public static FluentAPI.Entities.CompanyDetail CompanyMap(Models.cdetail c)
        {
            return new FluentAPI.Entities.CompanyDetail()
            {
                UserId=c.user_id,
                CompanyName=c.CompanyName,
                Experience=c.Experience,
            };
        }
        public static FluentAPI.Entities.EducationDetail EducationMap(Models.Edetail s)
        {
            return new FluentAPI.Entities.EducationDetail()
            {
                UserId = s.user_id,
                InstitutionName = s.institutionName,
                Degree = s.Degree,
                Specialization = s.Specialization,
                PassingYear = s.PassingYear,

            };
        }
        public static FluentAPI.Entities.SkillsDetail SkillMap(Models.Sdetail s)
        {
            return new FluentAPI.Entities.SkillsDetail()
            {
                UserId = s.user_id,
                Skill1 = s.Skill1,
                Skill2 = s.Skill2,
                Skill3 = s.Skill3,
            };
        }
        public static IEnumerable<Models.Trainerdata> TrainerMap(IEnumerable<FluentAPI.Entities.TrainerDetail> s)
        {
            return s.Select(TrainerMap);
        }

        public static IEnumerable<Models.Edetail> EducationMap(IEnumerable<FluentAPI.Entities.EducationDetail> s)
        {
            return s.Select(EducationMap);
        }

        public static IEnumerable<Models.cdetail>CompanyMap(IEnumerable<FluentAPI.Entities.CompanyDetail> s)
        {
            return s.Select(CompanyMap);
        }
    }
}
