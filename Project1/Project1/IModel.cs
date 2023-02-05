using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IModel<T>
    {
        List<T> AllTrainerData();
       // T AddTrainer(T trainer,Edetail e,cdetail c,Sdetail s);

        T AddTrainer(T trainer);

        T UpdateTrainer(T Trainerdata);

        T DeleteTr(string Name);

        //List<T> GetAllTrainerData();
    }
}
