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
            int option = 0;
            bool loopOption = true;
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
                        bool loopCelsius = true; 
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

                        break;
                    }

                case 2:
                    {
                        bool loopFahrenheit = true;
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

                        break;
                    }
            }
        } 
    }
}
