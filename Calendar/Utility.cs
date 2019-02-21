// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Calendar
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Utility
    {
        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            if (input.Trim().Equals(string.Empty))
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks the leap year.
        /// </summary>
        public static void CheckLeapYear()
        {
            try
            {
                int year;
                bool keepLooping = true;
                //// Keeps asking for year  untill valid year is given
                while (keepLooping)
                {
                    Console.WriteLine("Enter the year you want to check");
                    string stringYear = Console.ReadLine();

                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid year");
                        continue;
                    }

                    if (stringYear.Length != 4)
                    {
                        Console.WriteLine("Year should be of 4 digit number.");
                        continue;
                    }
                    else
                    {
                        year = Convert.ToInt32(stringYear);

                        if (year % 4 == 0 && year % 100 != 0)
                        {
                            Console.WriteLine("Year " + year + " is a Leap Year");
                        }
                        else
                        {
                            if (year % 400 == 0)
                            {
                                Console.WriteLine("Year " + year + " is a Leap Year");
                            }
                            else
                            {
                                Console.WriteLine("Year " + year + " is not a Leap Year");
                            }
                        }
                    }

                    keepLooping = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static int DayOfWeek(int month, int day, int year)
        {
            int y0 = year - (14 - month) / 12;
            int x = y0 + (y0 / 4) - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;
            return d0;
        }
    }
}
