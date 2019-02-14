// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
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
    /// to check weather given Strings are Anagrams
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Anagrams the string.
        /// </summary>
        public static void AnagramString()
        {
            Console.WriteLine("Enter the 1st String");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the 2nd String");
            string secondString = Console.ReadLine();


            if (Utility.CheckAnagram(firstString ,secondString))
            {
                Console.WriteLine("The Given Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("The Given Strings are  not Anagrams");
            }
        }        
    }
}
