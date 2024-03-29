﻿using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI
{
    public class EducationRepo : IEduRepo<Entities.EducationDetail>
    {
        private readonly TrainerdatabaseContext _context;
        public EducationRepo(TrainerdatabaseContext context)
        {
            _context = context;
        }

        EducationDetail IEduRepo<EducationDetail>.AddTrainerEducation(EducationDetail education)
        {
            _context.Add(education);
            _context.SaveChanges();
            return education;
        }

        public EducationDetail UpdateEducation(EducationDetail trainer)
        {

            _context.EducationDetails.Update(trainer);
            _context.SaveChanges();
            return trainer;
        }

        public List<EducationDetail> GetAllEducation()
        {
            return _context.EducationDetails.ToList();
        }

    }
}
