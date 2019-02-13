// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicNumbers.cs" company="Bridgelabz">
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
    /// Prints the harmonic Value of given Number(N) . 
    /// </summary>
    public class HarmonicNumbers
    {
        /// <summary>
        /// Gets the harmonic value.
        /// </summary>
        public static void GetHarmonicValue()
        {
            try
            {
                double sum = 0;
                bool keepLooping = true; ////for keep repeating program  untill a valid Integer is given.
                while (keepLooping)
                {
                    Console.WriteLine("Enter a Number");
                    string snumber = Console.ReadLine();
                    if (Utility.IsNumber(snumber) == false)
                    {
                        Console.WriteLine("Invalid Number, Enter only Integers");
                        continue;
                    }
                    else
                    {
                        int number = Convert.ToInt32(snumber);
                        if (number <= 0)
                        {
                            Console.WriteLine("Enter a Number greater than Zero.");
                            continue;
                        }
                        else
                        {
                            //// To keep adding to sum until 1/1 + 1/2 + ... + 1/N ;
                            for (int i = 1; i <= number; i++)
                            {
                                sum = sum + (1 / i);
                            }

                            Console.WriteLine("harmonic value for number " + number + "is " + sum);
                            keepLooping = false;
                        }
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
