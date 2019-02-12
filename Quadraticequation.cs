using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    public class Quadraticequation
    {
        public static void Quadraticroots()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            bool aflag = true;
            while (aflag)
            {
                Console.WriteLine("Enter a value for 'a' ");
                string stra = Console.ReadLine();
                if (Utility.IsNumber(stra) == false)
                {
                    Console.WriteLine("value for a can only be an int or decimal");
                    continue;
                }
                else
                {
                    a = Convert.ToInt32(stra);
                    if (a == 0)
                    {
                        Console.WriteLine("value for 'a' should be greater than zero");
                    }
                    else
                    {
                        aflag = false;
                    }                  
                }
            }

            bool bflag = true;
            while (bflag)
            {
                Console.WriteLine("Enter a value for 'b' ");
                string strb = Console.ReadLine();
                if (Utility.IsNumber(strb) == false)
                {
                    Console.WriteLine("value for 'b' can only be an int or decimal");
                    continue;
                }
                else
                {
                    b = Convert.ToInt32(strb);
                  
                       bflag = false;          
                }
            }

            bool cflag = true;
            while (cflag)
            {
                Console.WriteLine("Enter a value for 'c' ");
                string strc = Console.ReadLine();
                if (Utility.IsNumber(strc) == false)
                {
                    Console.WriteLine("value for 'c' can only be an int or decimal");
                    continue;
                }
                else
                {
                    c = Convert.ToInt32(strc);
                    cflag = false;
                }
            }

            double d1 = -b + Math.Sqrt(b * b - (4 * a * c));
            double d2 = -b - Math.Sqrt(b * b - (4 * a * c));

            Console.WriteLine("The roots are ");
               
            Console.WriteLine("x = " + d1 / (2 * a));
            Console.WriteLine("y = " + d2 / (2 * a));

        }
    }
}
