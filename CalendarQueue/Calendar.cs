﻿

namespace DataStructures.CalendarQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Calendar
    {
        public static void PrintCalendar(int month, int year)
        {
            MyQueue<int> queueInt = new MyQueue<int>();
            MyQueue<string> queueString = new MyQueue<string>();
            string[] monthsArray = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] days = { "S", "M", "Tu", "W", "Th", "F", "S" };

            if (month == 2 && Utility.CheckLeapYear(year))
            {
                numberOfDaysArray[month] = 29;
            }

            Console.WriteLine(monthsArray[month]);
            Console.WriteLine(year);
            Console.WriteLine(" S M T W TH F S");

            int day = Utility.DayOfWeek(month, 1, year);

            for (int i = 1; i<numberOfDaysArray[month]; i++)
            {
                queueInt.Enqueue(i);
            }

            for (int i = 0; i < days.Length; i++)
            {
                queueString.Enqueue(days[i]);      
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(queueString.Dequeue() + "\t");
            }

            Console.WriteLine();
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= numberOfDaysArray[month]; i++)
            {
                if (i < 10)
                {
                    Console.Write("" + queueInt.Dequeue() + "\t");      
                }

                if (i > 9)
                {
                    Console.Write("" + i + "\t");
                }

                if ((i + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
