// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Primefactors.cs" company="Bridgelabz">
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
    /// For finding prime Numbers of given Number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Gets the prime factors.
        /// </summary>
        public static void GetPrimeFactors()
        {
            try
            {
                bool keepLooping = true;
                ////for keep repeating program  untill a valid Integer is given.
                while (keepLooping)
                {
                    Console.WriteLine("Enter a Number you want Prime Factors for.");
                    string snumber = Console.ReadLine();

                    if (Utility.IsNumber(snumber) == false)
                    {
                        Console.WriteLine("Invald Input , Enter only integers");
                        continue;
                    }
                    else
                    {
                        int number = Convert.ToInt32(snumber);
                        Console.WriteLine("The Prime Factors of " + number + " are");
                        while (number % 2 == 0)
                        {
                            number = number / 2;
                            Console.WriteLine("2 ");
                        }

                        ////keeps dividing a number untill the iterator reaches the number.
                        for (int i = 3; i <= number; i = i + 2)
                        {
                            if (number % i == 0)
                            {
                                Console.WriteLine(i);
                                number = number / i;
                            }
                        }

                        keepLooping = false; //// program ended sucessfully                  
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }  
        }
    }
}
