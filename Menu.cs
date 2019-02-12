// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Shows the list of programs you can choose from.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {           
            int option = -1;///option for choosing a number from menu.
            bool flag = true;///flag for keep looping untill a valid option from the existing menu is choose.
            while (flag)
            {
                Console.WriteLine("======================================================================================================================");
                Console.WriteLine("Select the program from below .Enter 0 to exit");
                Console.WriteLine("1) Replace String Template");
                Console.WriteLine("2) CoinFlip");
                Console.WriteLine("3) LeapYear");
                Console.WriteLine("4) Power Of 2");
                Console.WriteLine("5) Harmonic value");
                Console.WriteLine("6) Prime Factors");
                Console.WriteLine("7) Gambler");
                Console.WriteLine("8) Sum Of Triplets to 0");
                Console.WriteLine("9) Distance");
                Console.WriteLine("10) StopWatch");
                Console.WriteLine("======================================================================================================================");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Command");
                    continue;
                }

                switch (option)
                {
                    case 0:
                        {
                            flag = false;
                            break;
                        }

                    case 1:
                        {
                            ReplaceString.ReplaceName();
                            break;
                        }

                    case 2:
                        {
                            CoinFlip.FlipCoin();
                            break;
                        }

                    case 3:
                        {
                            LeapYear.CheckLeapYear();

                            break;
                        }

                    case 4:
                        {
                            PowerOf2.PowerOfTwo();
                            break;
                        }

                    case 5:
                        {
                            HarmonicNumbers.GetHarmonicValue();
                            break;
                        }
                    case 6:
                        {
                            PrimeFactors.GetPrimeFactors();
                            break;
                        }

                    case 7:
                        {
                            Gambler.GamblerPlay();
                            break;
                        }

                    case 8:
                        {
                            Triplets.FindTriplet();
                            break;
                        }

                    case 9:
                        {
                            Distance.CalculateEuclideanDistance();

                            break;
                        }

                    case 10:
                        {
                            StopWatchProgram.StartStopWatch();

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }
            }
        }
    }
}
