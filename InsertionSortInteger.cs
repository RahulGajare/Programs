// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSortInteger.cs" company="Bridgelabz">
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
    /// Sorts the Integers using Insertion Sort
    /// </summary>
    public class InsertionSortInteger
    {
        /// <summary>
        /// Integers the insertion sort.
        /// </summary>
        public static void IntegerInsertionSort()
        {
            int[] userArray = Utility.TakeInputIntArray();
            Console.WriteLine("Insertion Sorted");
            Utility.PrintArrayInt(Utility.InsertionSortInt(userArray));
            Console.Read();
        }
    }
}
