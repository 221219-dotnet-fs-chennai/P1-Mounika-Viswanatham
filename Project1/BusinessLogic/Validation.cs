using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public  class Validation
    { 
        public Validation() { 
        }
        public static string ValidEmailID(string  email)
        {
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
            if (!Regex.IsMatch(email,pattern))
            {
                throw new Exception("check your email pattern");

            }
            else
            {
                return email;
            }
        }
        public static string ValidName(string name)
        {
            string pattern5 = "^[A-Za-z\\s]+$";
            if (!Regex.IsMatch(name, pattern5))
            {
                throw new Exception("enter correct name and name should not contain digits");
                //return name;
            }
            else
            {
                 return name;
               
            }
        }

        public static string ValidPassword(string password)
        {
            string pattern3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\\$%\\^&\\*]).{8,}$";
            if(!Regex.IsMatch(password,pattern3))
            {
                throw new Exception("Password format not correct");
            }
            else
            {
                return password;
            }

        }
        public static string ValidAge(string age) {

            string pattern4 = "^([3-6][0-9])$";
            if(!Regex.IsMatch(age,pattern4))
            {
                throw new Exception("Age should be in 2 digits and >=30 and <=69 ");
            }
            else
            {
                return age;
            }
        }

        public static string ValidPhoneNumber(string phonenumber) 
        {
            string pattern8= "^\\d{10}$";
            if(!Regex.IsMatch(phonenumber,pattern8))
            {
                throw new Exception("Phonenumber  should be in 10 digits");
            }
            else
            {
                return phonenumber;
            }

        }

        public static  string ValidPassingYear(string year)
        {
            string pat = "^\\d{4}$";
            if (!Regex.IsMatch(year,pat))
            {
                throw new Exception("year should contain only 4 digits ");
            }
            else
            {
                return year;
            }
        }

        public static string ValidExperience(String exp)
        {
            string patr = "^\\d{1,2}$";
            if (!Regex.IsMatch(exp, patr))
            {
                throw new Exception("Experience should be in 2 digits");
            }
            else
            {
                return exp;
            }
        }
    }
}
