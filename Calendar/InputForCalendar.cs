//-------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForCalendar.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------


namespace DataStructures.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class InputForCalendar
    {
        public static void StartCalendar(string[] args)
        {
            int year = 0;
            int month = 0;

            if (args.Length < 2 || args.Length > 2)
            {
                Console.WriteLine("Please Enter the month and Year");
                Console.Read();
                return;
            }

            if (Utility.IsNumber(args[0]) == false)
            {
                Console.WriteLine("Invalid Month");
                Console.Read();
                return;
            }

            month = Convert.ToInt32(args[0]);
            if (month <= 0 || month > 12)
            {
                Console.WriteLine("Invalid Month");
                Console.Read();
                return;
            }

            if (Utility.IsNumber(args[1]) == false)
            {
                Console.WriteLine("Invalid year");
                Console.Read();
                return;
            }

            if (args[1].Length < 4)
            {
                Console.WriteLine("Wrong Year specified");
                Console.Read();
                return;
            }

            year = Convert.ToInt32(args[1]);

            Calendar.PrintCalendar(month, year);
        }
    }
}
