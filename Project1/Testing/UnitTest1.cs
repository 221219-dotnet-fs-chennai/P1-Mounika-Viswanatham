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
    }
}