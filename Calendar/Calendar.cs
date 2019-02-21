using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Calendar
{
    public class Calendar
    {
        static int[,] calendar = new int[5,7];
        static int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public static void InitCal()
        {
            for (int i = 0; i < calendar.Length; i++)
            {
                for (int j = 0; j < calendar.GetLength(i); j++)
                {
                    calendar[i,j] = -10;
                }
            }
        }

        public static void Display(int m)
        {
           Console.WriteLine("	Sun	Mon	Tue	Wed	Thu	Fri	Sat");

            for (int i = 0; i < calendar.Length; i++)
            {
                for (int j = 0; j < calendar.GetLength(i); j++)
                {
                    if (calendar[i,j] < 0 || calendar[i,j] > month[m - 1])
                    {
                        Console.WriteLine("\t ");
                    }
                    else if (calendar[i,j] > 0)
                    {
                        Console.WriteLine("\t" + calendar[i,j] + " ");
                    }
                }
                Console.WriteLine("\t");
            }
        }

        public static void PutCalendar(int d)
        {
            int d1 = 1;
            for (int i = d; i < calendar.GetLength(0); i++)
            {
                // System.out.print(d1);
                calendar[0,i] = d1++;
            }
            for (int i = 1; i < calendar.Length; i++)
            {
                for (int j = 0; j < calendar.GetLength(i); j++)
                {
                    calendar[i,j] = d1++;
                }
            }

        }

        public static void DispCalendar(int m, int y)
        {
            int d = DayOfWeek(m, y);
            InitCal();
            PutCalendar(d);
            Display(m);

        }

        public static int DayOfWeek(int m, int y)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }

        
    }
}
