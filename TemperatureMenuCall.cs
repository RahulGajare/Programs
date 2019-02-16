// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureMenuCall.cs" company="Bridgelabz">
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
    /// Calls the Temperature Conversion Method
    /// </summary>
    public class TemperatureMenuCall
    {
        /// <summary>
        /// Celsius to fahrenheit.
        /// </summary>
        /// <exception cref="Exception"> Catches Exception</exception>
        public static void CelsiusToFarhenheit()
        {
            try
            {
                bool loopCelsius = true;
                ////keeps looping till correct value for Celsius is given
                while (loopCelsius)
                {
                    Console.WriteLine("Enter the Celsius value");
                    string stringCelsius = Console.ReadLine();

                    if (Utility.IsNumber(stringCelsius) == false)
                    {
                        Console.WriteLine("Invalid value for Celsius Specified");
                        continue;
                    }

                    Console.WriteLine(Utility.CelsiusToFahrenheit(Convert.ToInt32(stringCelsius)));
                    loopCelsius = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Fahrenheit to celsius.
        /// </summary>
        /// <exception cref="Exception"> Catch Exception</exception>
        public static void FarhenheitToCelsius()
        {
            try
            {
                bool loopFahrenheit = true;
                ////keeps looping till correct value for Fahrenheit is given
                while (loopFahrenheit)
                {
                    Console.WriteLine("Enter the Fahrenheit value");
                    string stringFahrenheit = Console.ReadLine();

                    if (Utility.IsNumber(stringFahrenheit) == false)
                    {
                        Console.WriteLine("Invalid value for Celsius Specified");
                        continue;
                    }

                    Console.WriteLine(Utility.FahrenheitToCelsius(Convert.ToInt32(stringFahrenheit)));
                    loopFahrenheit = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
