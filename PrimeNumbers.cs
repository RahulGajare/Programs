// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumber.cs" company="Bridgelabz">
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
    /// prints prime Numbers
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// prints prime Numbers between given range
        /// </summary>
        public static void PrintPrimeNumber()
        {
            Utility.PrintArrayList(Utility.GetPrimeNumbersList());
            
            Console.Read();
        }     
    }
}
