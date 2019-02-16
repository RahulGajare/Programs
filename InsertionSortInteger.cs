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
    using System.Diagnostics;
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
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                int[] userArray = Utility.TakeInputIntArray();
                Console.WriteLine("Insertion Sorted");
                stopWatch.Start();
                Utility.PrintArrayInt(Utility.InsertionSortInt(userArray));
                stopWatch.Stop();
                Console.WriteLine("Elapsed time = " + stopWatch.Elapsed);
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
