using BusinessLogic;
using NUnit.Framework;
using System;
using FluentAPI.Entities;
using Models;

namespace Testing
{   
    [TestFixture]
    public class TestMapper
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TrainerMap()
        {
            Trainerdata td= new Trainerdata();
            var m=Mapper.TrainerMap(td);
            Assert.AreEqual(m.GetType(),typeof(TrainerDetail));
        }

        [Test]
        public void SkillMap()
        {
            Sdetail sd = new Sdetail();
            var m = Mapper.SkillMap(sd);
            Assert.AreEqual(m.GetType(),typeof(SkillsDetail));

        }

        [Test]
        public void EduMap()
        {
            Edetail e=new Edetail();
            var m = Mapper.EducationMap(e);
            Assert.AreEqual(m.GetType(),typeof(EducationDetail));


        }

        [Test]
        public void ComMap()
        {
            cdetail c = new cdetail();
            var m = Mapper.CompanyMap(c);
            Assert.AreEqual(m.GetType(),typeof(CompanyDetail));
        }
    }
}
