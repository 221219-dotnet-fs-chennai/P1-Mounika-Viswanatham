using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAPI.Entities;
using Model;
namespace FluentAPI
{
    public class EFRepo : IRepo<FluentAPI.Entities.TrainerDetail>
    {
        TrainerdatabaseContext context = new TrainerdatabaseContext();


        public Entities.TrainerDetail Add(Entities.TrainerDetail trainerdata)
        {
            //throw new NotImplementedException();

            context.Add(trainerdata);
            context.SaveChanges();
            return trainerdata;
        }

        

        public List<Entities.TrainerDetail> FindTrainerByLocation() 
        {
            return context.TrainerDetails.ToList();
        }

        public List<Entities.TrainerDetail> GetTrainerDisconnected()
        {
            //throw new NotImplementedException();
            return context.TrainerDetails.ToList();
        }

       /* public bool Login(string email)
        {
            // throw new NotImplementedException();
           // return context.TrainerDetails.ToList();
            
        }
*/
        /*public void TrainerDelete(string? columnName, string? tableName, string? userId)
        {
            //throw new NotImplementedException();
          

          
        }

        public void TrainerUpdate(string? newData, string? columnName, string? tableName, string? userId)
        {
            throw new NotImplementedException();
            

        }*/
    }
}
