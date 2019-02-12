// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ----------------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// tells the result of Windchill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Calculates the wind chill.
        /// </summary>
        public static void CalculateWindChill()
        {
            double tempearature = 0;
            double velocity = 0;
            double result;

            bool tempFlag = true;
            while (tempFlag)
            {
                Console.WriteLine("Enter the temperature in farenheit");
                {
                    string strTemperature = Console.ReadLine();
                    if (Utility.IsNumber(strTemperature) == false)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }
                    else
                    {
                        tempearature = Convert.ToDouble(strTemperature);
                        tempFlag = false;
                    }
                }
            }

            bool velocityFlag = true;
            while (velocityFlag)
            {
                Console.WriteLine("Enter the Velocity in Miles/hour");
                {
                    string strvelocity = Console.ReadLine();
                    if (Utility.IsNumber(strvelocity) == false)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }
                    else
                    {
                        velocity = Convert.ToDouble(strvelocity);
                        velocityFlag = false;
                    }
                }
            }

            result = 35.74 + (0.6215 * tempearature) + ((0.4275 * tempearature - 35.75) * Math.Pow(velocity, 0.16));

            Console.WriteLine("The Tempearature will be = " + result + "°F");
        }
    }
}
