// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
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
    /// Used To Convert Temperatures
    /// </summary>
    public class Temperatureconversion
    {
        /// <summary>
        /// shows the option for Conversion
        /// </summary>
        public static void ConvertTemp()
        {
            try
            {
                int option = 0;
                bool loopOption = true;
                ////Keeps looping till user selects a valid Option.
                while (loopOption) 
                {
                    Console.WriteLine("Press 1) From Celsius to Fahreinheit");
                    Console.WriteLine("Press 2) From Fahreinheit to Celsius");
                    string stringOption = Console.ReadLine();

                    if (Utility.IsNumber(stringOption) == false)
                    {
                        Console.WriteLine("Invalid choice");
                        continue;
                    }

                    option = Convert.ToInt32(stringOption);

                    if (option != 1 && option != 2)
                    {
                        Console.WriteLine("Invalid choice");
                        continue;
                    }

                    loopOption = false;
                }

                switch (option)
                {
                    case 1:
                        {
                            TemperatureMenuCall.CelsiusToFarhenheit();
                            break;
                        }

                    case 2:
                        {
                            TemperatureMenuCall.FarhenheitToCelsius();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
    }
}
