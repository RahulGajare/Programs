// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramStack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.PrimeAnagramStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prime Anagram Stack
    /// </summary>
    public class PrimeAnagramStack
    {
        /// <summary>
        /// Starts the prime anagram stack.
        /// </summary>
        public static void StartPrimeAnagramStack()
        {
           ArrayList primeAnagramList = Utility.GetAnagrams(Utility.GetPrimeNumbersList());

            Stack primeAnagramStack = new Stack();
            primeAnagramStack.StackInitialise(1000);

            foreach (string word in primeAnagramList)
            {
                primeAnagramStack.Push(word);
            }

            Console.WriteLine("pushed To Stack");
            while (primeAnagramStack.Pop() != string.Empty)
            {
                Console.WriteLine(primeAnagramStack.Pop());
            }
            Console.WriteLine("Poped Out of Stack in ReverseOreder");
        }
    }
}
