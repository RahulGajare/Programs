// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimePalindrome.cs" company="Bridgelabz">
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
    /// prints Prime Number that are palindrome
    /// </summary>
    public class PrimePalindrome
    {
        /// <summary>
        /// Primes the palindromes.
        /// </summary>
        public static void PrimePalindromes()
        {
            try
            {
                Utility.PrintPrimePalindrome(Utility.GetPrimeNumbersList());
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
