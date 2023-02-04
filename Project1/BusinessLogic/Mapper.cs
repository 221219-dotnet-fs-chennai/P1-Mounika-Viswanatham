using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI.Entities;
using System.Net.Cache;

namespace BusinessLogic
{
    public class Mapper
    {
        public static Models.Trainerdata  TrainerMap(FluentAPI.Entities.TrainerDetail s)
        {
            return new Models.Trainerdata()
            {

                user_id = s.UserId,
                Name  = s.Name,
                EmailID=s.EmailId,
                PhoneNumber=s.PhoneNumber,
                Gender=s.Gender,
                Age=Convert.ToInt32(s.Age),
                Location=s.Location,


                
            
            };


        }

        public static FluentAPI.Entities.TrainerDetail TrainerMap(Models.Trainerdata e)
        {
            return new FluentAPI.Entities.TrainerDetail()
            {
                UserId = e.user_id,
                Name = e.Name,
                EmailId = e.EmailID,
                PhoneNumber = e.PhoneNumber,
                Gender = e.Gender,
                Age = Convert.ToInt32(e.Age),
                Location=e.Location,
            };
        }

        public static IEnumerable<Models.Trainerdata> TrainerMap(IEnumerable<FluentAPI.Entities.TrainerDetail> s)
        {
            return s.Select(TrainerMap);
        }
    }
}
