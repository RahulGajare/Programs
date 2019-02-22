// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Calendar.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Print calendar of given month and year
    /// </summary>
    public class Calendar
    {
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                string[] monthsArray = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" S M T W TH F S");

                int day = Utility.DayOfWeek(month, 1, year);

                for (int i = 0; i < day; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i <= numberOfDaysArray[month]; i++)
                {
                    Console.Write(i + " ");

                    if ((i + day) % 7 == 0 || (i == numberOfDaysArray[month]))
                    {
                        Console.WriteLine();
                    }
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
