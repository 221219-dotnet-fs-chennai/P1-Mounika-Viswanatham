using Models;
using FluentAPI.Entities;

namespace FluentAPI
{
    public class EFRepo:IModel<Entities.TrainerDetail>
    {
        private readonly TrainerdatabaseContext _context;
        public EFRepo(TrainerdatabaseContext context)
        {
            _context= context;
        }

        public TrainerDetail AddTrainer(TrainerDetail trainer)
        {
            //throw new NotImplementedException();
            _context.Add(trainer);
            _context.SaveChanges();

            return trainer;
        }

        public List<Entities.TrainerDetail> AllTrainerData()
        {
            //throw new NotImplementedException();
            return _context.TrainerDetails.ToList();
        }
        public IEnumerable<Entities.TrainerDetail>FindTrainerByEmailID()
        {
            return _context.TrainerDetails.ToList();
        }

        public IEnumerable<Entities.TrainerDetail> FindTrainerByLocation()
        {
            return _context.TrainerDetails.ToList();
        }

        public TrainerDetail UpdateTrainer(TrainerDetail trainerdata)
        {
            //throw new NotImplementedException();
            _context.TrainerDetails.Update(trainerdata);
            _context.SaveChanges();
            return trainerdata;
        }
    }
}