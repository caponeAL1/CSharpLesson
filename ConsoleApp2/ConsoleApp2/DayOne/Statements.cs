﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayOne
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter Your AGE");
            string ageAsString=Console.ReadLine();
            if(!IsNumeric(ageAsString))
            {
                return;
            }
            int age= int.Parse(ageAsString);
            if(age < 18 )
            {
                Console.WriteLine("SORRY!! You cant drive");
            }
            else
            {
                Console.WriteLine("Yes, you can Drive");
            }
            
        }
        public static bool IsNumeric(String pValue)
        {
            bool result = false;
            if (pValue == null)
            {
                Console.WriteLine("INVALID String!!! Value is NULL....");
                return false;
            }
            char[] data = pValue.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not a NUMBER!!!");
                    return false;
                }
            }
            result = true;
            return result;
        }
        public static void DoLogin()
        {
            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();
            bool flag = CheckName(name);
            if (!flag)
            {
                return;
            }
            Console.WriteLine("Enter Your PASSWORD");
            String pwd = Console.ReadLine();
            flag = CheckPassword(pwd);
            if (!flag)
            {
                return;
            }
            Console.WriteLine($"Welcome {name} Your Password is {pwd}");
        }
        public static bool CheckName(String name)
        {
            bool result = false;
            if (string.IsNullOrEmpty(name))
            {
                result = false;
                Console.WriteLine("Name is NULL or EMPTY");
            }
            name = name.Trim().ToLower();
            char[] chars = name.ToCharArray();
            int length = chars.Length;
            if (length < 3 || length > 15)
            {
                Console.WriteLine("Name Length Must be between 3 and 15!!!");
                result = false;
                return result;
            }
            for (int i = 0; i < length; i++)
            {
                int ascii = chars[i];
                if (ascii < 97 || ascii > 122)
                {
                    Console.WriteLine($"Invalid char in NAME {chars[i]}");
                    result = false;
                    return result;
                }
            }
            result = true;
            return result;
        }
        public static bool CheckPassword(String pwd)
        {
            bool result = false;
            int numberCount = 0;
            int upperCaseCount = 0;
            int lowerCaseCount = 0;
            int symbolCount = 0;
            if (string.IsNullOrEmpty(pwd))
            {
                result = false;
                Console.WriteLine("Password is NULL or EMPTY");
            }
            pwd = pwd.Trim();
            char[] chars = pwd.ToCharArray();
            int length = chars.Length;
            if (length < 8 || length > 15)
            {
                Console.WriteLine("Password Length Must be between 8 and 15!!!");
                result = false;
                return result;
            }
            for (int i = 0; i < length; i++)
            {
                int ascii = chars[i];
                if (ascii > 64 || ascii <= 90)
                {
                    upperCaseCount++;
                }
                if (ascii > 95 || ascii <= 122)
                {
                    lowerCaseCount++;
                }
                if (ascii > 47 || ascii <= 58)
                {
                    numberCount++;
                }
                if (chars[i] == '$' || chars[i] == '@' || chars[i] == '%' || chars[i] == '*' || chars[i] == '_')
                {
                    symbolCount++;
                }
            }
            if (upperCaseCount == 0 || lowerCaseCount == 0 || symbolCount == 0 || numberCount == 0)
            {
                Console.WriteLine("Password Must atleast 1 UPPERCASE / NUMBER / Special CASE / LOWERCASE !!!");
                result = false;
                return result;
            }
            result = true;
            return result;
        }
    }
}
