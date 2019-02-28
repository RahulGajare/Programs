using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP.RegexReplace
{
    class UserInfo
    {
        public static void TakeUserInfo()
        {
            string name = string.Empty;
            string fullName = string.Empty;
            string contactNumber = string.Empty;

            ////// loops till input for name matches the expression.
            //while (true)
            //{
            //    Console.WriteLine("Enter your Name");
            //    name = Console.ReadLine();

            //    if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            //    {
            //        Console.WriteLine("Wrong input");
            //        continue;
            //    }


            //    break;
            //}

            ////loops till input for Full Name matches the expression.
            while (true)
            {
                Console.WriteLine("Enter your Full Name (First last)");
                fullName = Console.ReadLine();

                if (!Regex.IsMatch(fullName, "^[a-zA-z]+\\s[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }

                break;
            }

           //// loops till input for Contact Number matches the expression.
            while (true)
            {
                Console.WriteLine("Enter your Contact Number (10 digits)");
                contactNumber = Console.ReadLine();

                if (!Regex.IsMatch(contactNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }


                break;
            }

            string[] nameArray = fullName.Split(" ");

            PatternReplacer.ReplacePattern(nameArray[0], fullName, contactNumber);


        }
    }
}
