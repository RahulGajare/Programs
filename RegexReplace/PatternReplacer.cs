// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="PatternReplacer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.RegexReplace
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// PatternReplacer Class
    /// </summary>
    public class PatternReplacer
    {
        /// <summary>
        /// Replaces the pattern.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fullName">The full name.</param>
        /// <param name="contactNumber">The contact number.</param>
        public static void ReplacePattern(string name, string fullName , string contactNumber)
        {
            //// Reads the Message from file to replace.
            string message= System.IO.File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Message.txt");

            ////following are the patterns in message to replace with the user details.
            string namePattern = "<<name>>";
            string fullNamePattern = "<<full name>>";
            string contactNumberPattern = "<<91-xxxxxxxxxx>>";
            string datePattern = "01/01/2016";
            string date = DateTime.Now.ToShortDateString();

            ////Replaces the message with user details on the specifies pattern.
            message = Regex.Replace(message,namePattern,name);
            message = Regex.Replace(message, fullNamePattern, fullName);
            message = Regex.Replace(message, contactNumberPattern, contactNumber);
            message = Regex.Replace(message, datePattern, date);

            Console.WriteLine(message);
            Console.Read();
        }
    }
}
