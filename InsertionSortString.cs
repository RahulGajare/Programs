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
    using System.Diagnostics;
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
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                string[] userArray = Utility.TakeInputStringArray();
                Console.WriteLine("Insertion Sorted");
                stopwatch.Start();
                Utility.PrintArrayString(Utility.InsertionSortString(userArray));
                stopwatch.Stop();
                Console.WriteLine("Elapsed time = " + stopwatch.Elapsed);
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
