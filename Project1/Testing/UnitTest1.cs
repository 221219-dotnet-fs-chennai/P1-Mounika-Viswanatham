using Models;
using BusinessLogic;
using FluentAPI;
using System;
namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        [TestCase("mounikav.199@gmail.com")]
        [TestCase("chintu@gmail.com")]
        public void TestEmailID(string Email)
        {
            Assert.AreEqual(Validation.ValidEmailID(Email),Email);
        }




        [Test]
        [TestCase("8367506198")]
        [TestCase("8797678")]
        public void TestPhonenumber(String PhoneNumber)
        {
            Assert.AreEqual(Validation.ValidPhoneNumber(PhoneNumber), PhoneNumber);
        }




        [Test]
        [TestCase("2022")]
        [TestCase("202")]
        public void TestPassingYear(string year)
        {
            Assert.AreEqual(Validation.ValidPassingYear(year), year);
        }



        [Test]
        [TestCase("1")]
        [TestCase("10")]
        [TestCase("111")]

        public void TestExperience(string exp)
        {
            Assert.AreEqual(Validation.ValidExperience(exp), exp);
        }


        [Test]
        [TestCase("25")]
        [TestCase("30")]
        [TestCase("69")]
        [TestCase("70")]
        

        public void TestAge(string age)
        {
            Assert.AreEqual(Validation.ValidAge(age), age);
        }

        [Test]
        [TestCase("Mounika")]
        [TestCase("Mounika12")]
        [TestCase("Viwanatham Mounika")]

        public void TestName(string Name)
        {
            Assert.AreEqual(Validation.ValidName(Name), Name);
        }
    }
}