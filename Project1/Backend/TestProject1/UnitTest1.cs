using BusinessLogic;
using FluentAPI;
using Models;
using System;
using NUnit.Framework;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.TestExecutor;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        

        [Test]
        [TestCase("mounikav.199@gmail.com")]
        [TestCase("mounikav.199gamil.com")]
        public void Test1(string Email)
        {
            Assert.AreEqual(Validation.ValidEmailID(Email), Email);    
        }

        [Test]
        [TestCase("8367506198")]
        [TestCase("8367506199")]
        public void Test2(string  phonenumber)
        {
            Assert.AreEqual(Validation.ValidPhoneNumber(phonenumber),phonenumber);
        }
    }
}