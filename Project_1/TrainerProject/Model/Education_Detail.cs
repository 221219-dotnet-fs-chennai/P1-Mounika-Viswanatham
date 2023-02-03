using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Education_Detail
    {
        public Education_Detail()
        {

        }

        public string user_id { get; set; }
        public string? institutionName { get; set; }
        public string? Degree { get; set; }
        public string? Specialization { get; set; }
        public string? PassingYear { get; set; }

        public string Education()
        {
            return $"Institution Name -{institutionName} {"\n"} Degree - {Degree} {"\n"} Specialization -  {Specialization} {"\n"} Passing Year - {PassingYear} ";       }



    }
}
