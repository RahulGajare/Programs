// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Takes two integer command-line arguments x and y and prints the Euclidean distance from the point (x, y) to the origin (0, 0).
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Calculates the euclidean distance.
        /// </summary>
        public static void CalculateEuclideanDistance()
        {
            double x = 0;
            double y = 0;
            bool xPositionFlag = true;
            bool yPositionFlag = true;

            //// Keeps asking for X postion untill valid Number is given
            while (xPositionFlag)
            {
                Console.WriteLine("Enter the x position");
                string xPosition = Console.ReadLine();

                if (Utility.IsNumber(xPosition) == false)
                {
                    Console.WriteLine("Wrong Input , Must be a number");
                    continue;
                }
                else
                {
                    x = Convert.ToDouble(xPosition);
                    xPositionFlag = false;
                }
            }

            //// Keeps asking for Y postion untill valid Number is given
            while (yPositionFlag)
            {
                Console.WriteLine("Enter the y position");
                string yPosition = Console.ReadLine();

                if (Utility.IsNumber(yPosition) == false)
                {
                    Console.WriteLine("Wrong Input , Must be a number");
                    continue;
                }
                else
                {
                    y = Convert.ToDouble(yPosition);
                    yPositionFlag = false;
                }
            }

            Console.WriteLine(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}
