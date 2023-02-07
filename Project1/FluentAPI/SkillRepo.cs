using FluentAPI.Entities;
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
    }
}
