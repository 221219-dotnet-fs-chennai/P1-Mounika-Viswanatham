using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class SkillRepo:ISkill<Entities.SkillsDetail>
    {
        private readonly TrainerdatabaseContext _con;
        public SkillRepo(TrainerdatabaseContext con)
        {
            _con = con;
        }



        SkillsDetail ISkill<SkillsDetail>.AddTrainerSkill(SkillsDetail c)
        {
            _con.Add(c);
            _con.SaveChanges();
            return c;
        }


        public SkillsDetail UpdateSkill(SkillsDetail trainer)
        {

            _con.SkillsDetails.Update(trainer);
            _con.SaveChanges();
            return trainer;
        }

        public List<SkillsDetail> GetAllSkills()
        {
            return _con.SkillsDetails.ToList();
        }

        public IEnumerable<Entities.SkillsDetail> FindTrainerBySkill()
        {
            return _con.SkillsDetails.ToList();
        }
    }
}
