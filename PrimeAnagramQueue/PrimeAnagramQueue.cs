// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.PrimeAnagramQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prime Anagram Queue Class
    /// </summary>
    public class PrimeAnagramQueue
    {
        /// <summary>
        /// Starts the prime anagram queue.
        /// </summary>
        public static void StartPrimeAnagramQueue()
        {
            try
            {
                ArrayList primeAnagramList = Utility.GetAnagrams(Utility.GetPrimeNumbersList());
                MyQueue<string> primeAnagramQueue = new MyQueue<string>();

                foreach (string word in primeAnagramList)
                {
                    primeAnagramQueue.Enqueue(word);
                }

                while (primeAnagramQueue.CheckSize() != 0)
                {
                    Console.WriteLine(primeAnagramQueue.Dequeue());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
