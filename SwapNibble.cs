// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SwapNibble.cs" company="Bridgelabz">
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
    /// Swaps the Nibbles of given Number
    /// </summary>
    public class SwapNibble
    {
        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        public static void SwapNibbles()
        {
            try
            {
                int userNumber = 0;
                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Enter the Number");
                    string stringUserNumber = Console.ReadLine();

                    if (Utility.IsNumber(stringUserNumber) == false)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    userNumber = Convert.ToInt32(stringUserNumber);
                    loop = false;
                }

                int swappedNibble = Utility.SwapNibbles(userNumber);
                Console.WriteLine(swappedNibble);
                if (Utility.PowerOf2(swappedNibble))
                {
                    Console.WriteLine("is Power of 2");
                }
                else
                {
                    Console.WriteLine("is not Power of 2");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }            
    }
}
