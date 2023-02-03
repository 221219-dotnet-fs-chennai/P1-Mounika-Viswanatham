using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class SkillsDetails
    {

        public string user_id { get; set; }
        public string? Skill1 { get; set; }
        public string? Skill2 { get; set; }
        public string? Skill3 { get; set; }

        public string skill()
        {
            return $"Skill1 -{Skill1} {"\n"} Skill2 - {Skill2} {"\n"} Skill3 - {Skill3}";
        }
    }
}
