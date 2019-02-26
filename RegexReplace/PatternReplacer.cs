using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP.RegexReplace
{
    class PatternReplacer
    {
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
