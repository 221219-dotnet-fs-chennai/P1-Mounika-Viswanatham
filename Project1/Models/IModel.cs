using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FluentAPI.Entities;
namespace Models
{
    public interface IModel<T>
    {
        List<T> AllTrainerData();

       // T AddTrainer(T trainer,Edetail e,cdetail c,Sdetail s);

        T AddTrainer(T trainer);

        //T AddTrainerEducation(T e);

        T UpdateTrainer(T Trainerdata);

        T DeleteTr(string EmailID);

        //List<T> GetAllTrainerData();
        IEnumerable<GetAllData> getAllTrainerdatas();

        //Models.Sdetail AddSkillDetail(Sdetail s);


        //T AddSkillDetail(T s);

        bool Login(string EmailID,string  Password);

        
    }
}
