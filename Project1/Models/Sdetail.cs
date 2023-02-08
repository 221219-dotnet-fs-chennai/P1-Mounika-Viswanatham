using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sdetail
    {
        public string user_id
        {
            get; set;
        }
        public string Skill1
        {
            get; set;
        }
        public string Skill2
        {
            get; set;
        }
        public string Skill3
        {
            get; set;
        }

        public string Skill()
        {
            return $@"{Skill1},{Skill2},{Skill3}";
        }
       
    }
}
