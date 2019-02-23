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

    /// <summary>
    /// Utility class
    /// </summary>
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
            try
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the leap year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>returns true or false</returns>
        /// <exception cref="Exception">throws exception</exception>
        public static bool CheckLeapYear(int year)
        {
            try
            {
                if (year % 4 == 0 && year % 100 != 0)
                {
                    return true;
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>returns day</returns>
        public static int DayOfWeek(int month, int day, int year)
        {
            try
            {
                int y0 = year - ((14 - month) / 12);
                int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                int m0 = month + (12 * ((14 - month) / 12)) - 2;
                int d0 = (day + x + (31 * m0 / 12)) % 7;
                return d0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
