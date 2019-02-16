// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sqrt.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Gives the Square root of Given Number
    /// </summary>
    public class Sqrt
    {
        /// <summary>
        /// Finds the SQRT.
        /// </summary>
        public static void FindSqrt()
        {
            try
            {
                double userNumber = 0;
                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Enter a positive Integer");
                    string stringNumber = Console.ReadLine();

                    try
                    {
                        userNumber = Convert.ToInt32(stringNumber);

                        if (userNumber <= 0)
                        {
                            Console.WriteLine("Enter only positive Number");
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter only positive Number");
                        continue;
                    }

                    loop = false;
                }

                double t = userNumber;
                double epsilon = 3.05902321 * System.Math.Exp(-7.0);

                while (Math.Abs(t - (userNumber / t)) > (epsilon * t))
                {
                    t = (userNumber / t) + (t / 2.0);
                }

                Console.WriteLine(t);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
