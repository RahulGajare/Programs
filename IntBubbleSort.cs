// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntBubbleSort.cs" company="Bridgelabz">
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
    /// Sorts using bubbleSort Method
    /// </summary>
    public class IntBubbleSort
    {
        /// <summary>
        /// Bubbles the sort int.
        /// </summary>
        public static void BubbleSortInt()
        {
            try
            {
                int[] userArray = Utility.TakeInputIntArray();
                Console.WriteLine("Bubble Sorted");
                Utility.PrintArrayInt(Utility.BubbleSortInt(userArray));
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
