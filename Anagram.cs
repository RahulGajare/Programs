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
            string firstString = string.Empty;
            string secondString = string.Empty;

            bool loop1 = true; //// for keep asking for first string untill valid string is given 
            while (loop1)
            {
                Console.WriteLine("Enter the 1st String");
                 firstString = Console.ReadLine();

                if (Utility.CheckString(firstString))
                {
                    Console.WriteLine("String cant be empty, Enter proper String");
                    continue;
                }

                loop1 = false;
            }

            bool loop2 = true; //// for keep asking for second string untill valid string is given
            while (loop2)
            {
                Console.WriteLine("Enter the 2nd String");
                secondString = Console.ReadLine();

                if (Utility.CheckString(secondString))
                {
                    Console.WriteLine("Name cant be empty, Enter proper name");
                    continue;
                }

                loop2 = false;
            }

            if (Utility.CheckAnagram(firstString, secondString))
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
