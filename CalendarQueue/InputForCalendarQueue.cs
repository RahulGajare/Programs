﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CalendarQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InputForCalendarQueue
    {
        public static void StartCalendar()
        {
            int month = 0;
            int year = 0;

            bool loopForMonth = true;
            while (loopForMonth)
            {
                Console.WriteLine("Enter the month");
                string stringMonth = Console.ReadLine();

                if (Utility.IsNumber(stringMonth) == false)
                {
                    Console.WriteLine("Invalid Month");

                    continue;
                }

                month = Convert.ToInt32(stringMonth);
                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Invalid Month");
                    continue;
                }

                loopForMonth = false;
            }

            bool loopForYear = true;
            while (loopForYear)
            {
                Console.WriteLine("Enter the year");
                string stringYear = Console.ReadLine();

                if (Utility.IsNumber(stringYear) == false)
                {
                    Console.WriteLine("Invalid Month");

                    continue;
                }

                if (stringYear.Length < 4)
                {
                    Console.WriteLine("Wrong Year specified");
                    Console.Read();
                    return;
                }

                year = Convert.ToInt32(stringYear);
                loopForYear = false;
            }

            Calendar.PrintCalendar(month,year);
        }
    }
}
