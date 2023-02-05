using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GetAllTrainerdata
    {
        public string user_id { get; set; } 
        public string EmailID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string institutionName { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public string PassingYear { get; set; }
        public string CompanyName { get; set; }
        public string Experience { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }

        public string GetAll() {


            return $@"EmailId       :{EmailID} {"\n"} 
                      Name          :{Name} {"\n"} 
                      Gender        :{Gender}{"\n"}
                      Age           :{Age}{"\n"}
                      PhoneNumber   :{PhoneNumber}{"\n"}
                      Location      :{Location}{"\n"}
                      InstitutionName:{institutionName}{"\n"}
                      Degree        :{Degree}{"\n"}
                      Specialization:{Specialization}{"\n"}
                      PassingYear   :{PassingYear}{"\n"}
                      CompanyName   :{CompanyName}{"\n"}
                      Experience    :{Experience}{"\n"}
                      Skill1        :{Skill1}{"\n"}
                      Skill2        :{Skill2}{"\n"}
                      Skill3        :{Skill3}{"\n"}
                      ";
        }
    }
}
