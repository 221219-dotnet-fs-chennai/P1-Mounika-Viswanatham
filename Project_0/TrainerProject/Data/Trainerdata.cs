﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public  class Trainerdata
    {
        public string? Name { get; set; }
        public string? EmailID { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Age { get; set; }
        public string? Location { get; set; }
        public string? institutionName { get; set; }
        public string? Degree { get; set; }
        public string? Specialization { get; set; }
       
        public string? Skill1 { get; set; }
        public string? Skill2 { get; set; }
        public string? Skill3 { get; set; }

        //public string? Position { get; set; }
        public string? Experience { get; set; }

        //public string? WebsiteLink { get; set; }
        public string? PassingYear { get; set; }

        public string? CompanyName { get; set; }

        public string AllTrainerData()
        {
            return $@"{Name},{EmailID},{Gender},{PhoneNumber},{Location}";

        }
        
    }
}
