﻿using FluentAPI.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public interface  ILogic
    {
        IEnumerable<Trainerdata> AllTrainerData();

        Trainerdata AddTrainer(Trainerdata trainerdata);

        Edetail AddTrainerEducation(Edetail e);

        cdetail AddTrainerCompany(cdetail c);

        Sdetail AddTrainerSkill(Sdetail s);


        
        IEnumerable<Trainerdata> FindTrainerByEmailID(string EmailID);

        IEnumerable<Trainerdata> FindTrainerByLocation(string Location);

        IEnumerable<Sdetail> FindTrainerBySkill(string SkillName);

        IEnumerable<cdetail> FindTrainerByExperience(string experience);
        
        Trainerdata UpdateTrainer(string Email,Trainerdata trainerdata);

        

        cdetail UpdateCompany(string user_id, cdetail c);

        Edetail UpdateEducation(string user_id,Edetail e);

        Sdetail UpdateSkill(string user_id, Sdetail s);


        Trainerdata DeleteTrainer(string Name);

        bool Login(string EmailID, string Password);


        IEnumerable<GetAllData> getAllTrainerdatas();

       IEnumerable<Sdetail> GetAllSkills();

        IEnumerable<cdetail> GetAllCompany();

        IEnumerable<Edetail> GetAllEducation();

       

    }
}
