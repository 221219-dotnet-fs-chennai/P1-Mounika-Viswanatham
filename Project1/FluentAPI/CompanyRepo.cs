using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace FluentAPI
{
    public class CompanyRepo :  ICompany<Entities.CompanyDetail>

    {
        private readonly TrainerdatabaseContext _con;
        public CompanyRepo(TrainerdatabaseContext con)
        {
            _con = con;
        }

        public List<CompanyDetail> GetAllCompany()
        {
            //throw new NotImplementedException();
            return _con.CompanyDetails.ToList();
        }

        CompanyDetail ICompany<CompanyDetail>.AddTrainerCompany(CompanyDetail c)
            
        {
            _con.Add(c);
            _con.SaveChanges();
            return c;
        }

        public IEnumerable<Entities.CompanyDetail> FindTrainerByExperience()
        {
            return _con.CompanyDetails.ToList();
        }
    }
}
