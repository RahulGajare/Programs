// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSortString.cs" company="Bridgelabz">
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
    /// Sorts String using insertion sort
    /// </summary>
    public class InsertionSortString
    {
        /// <summary>
        /// Strings the insertion sort.
        /// </summary>
        public static void StringInsertionSort()
        {
            string[] userArray = Utility.TakeInputStringArray();
            Console.WriteLine("Insertion Sorted");
            Utility.PrintArrayString(Utility.InsertionSortString(userArray));
            Console.Read();
        }
    }
}
