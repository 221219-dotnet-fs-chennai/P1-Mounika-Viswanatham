using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IEduRepo<T>
    {
        T AddTrainerEducation(T Education);
       
        T UpdateEducation(T e);

        List<T> GetAllEducation();

    }
}
