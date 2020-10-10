﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace User_Registration_Problem
{
    class ValidateUserRegistration
    {
        private static readonly string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static readonly string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        private static readonly string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public bool ValidateLastName(string LN)
        {
            return Regex.IsMatch(LN, Regex_LastName);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}