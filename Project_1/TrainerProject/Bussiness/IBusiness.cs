using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Bussiness
{
    public  interface IBusiness
    {
        IEnumerable<Trainerdata> GetTrainerDisconnected();


        Trainerdata FindTrainerByEmail();

        
        IEnumerable<Trainerdata> FindTrainerByLocation();
    }
}
