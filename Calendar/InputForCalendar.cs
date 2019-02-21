using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Calendar
{
    class InputForCalendar
    {
        public static void StartCalendar()
        {
            

                Console.WriteLine("enter month");
            int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter yaer");
            int y = Convert.ToInt32(Console.ReadLine());
            Calendar.DispCalendar(m ,y);
           
        }
    }
}
