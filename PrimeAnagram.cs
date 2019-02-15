// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram.cs" company="Bridgelabz">
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
    /// Prints prime Numbers That are Anagram
    /// </summary>
    public class PrimeAnagram
    {
        /// <summary>
        /// Prints the prime anagram.
        /// </summary>
        public static void PrintPrimeAnagram()
        {
            Utility.PrintAnagrams(Utility.GetPrimeNumbersList());
            Console.Read();
        }
    }
}
