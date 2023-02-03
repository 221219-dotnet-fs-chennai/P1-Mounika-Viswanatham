using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Trainerdata
    {
        public string user_id { get; set; }
        public string? Name { get; set; }
        public string? EmailID { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Age { get; set; }
        public string? Location { get; set; }
       
        
        //public string? Position { get; set; }
       
        public string AllTrainerData()
        {
            return $@" Name        - {Name} {"\n"} EmailId     - {EmailID} {"\n"} PhoneNumber - {PhoneNumber} {"\n"} Gender      - {Gender} {"\n"} Location    - {Location} {"\n"}  ";

        }

        
    }
}
