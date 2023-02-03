using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CompanyDetails
    {
        public CompanyDetails()
        {

        }
        public string user_id { get; set; }
        public string? Experience { get; set; }

        //public string? WebsiteLink { get; set; }

        public string? CompanyName { get; set; }

        public string comp()
        {
            return $"CompanyName - {CompanyName} {"\n"} Experience - {Experience}";
        }
    }
}
