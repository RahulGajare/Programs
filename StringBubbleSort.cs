// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringBubbleSort.cs" company="Bridgelabz">
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
    /// Sorts Strings Using Bubble Sort Method
    /// </summary>
    public class StringBubbleSort
    {
        /// <summary>
        /// String bubble sorts this instance.
        /// </summary>
        public static void Stringbubblesort()
        {
            string[] userArray = Utility.TakeInputStringArray();

            Utility.PrintArrayString(Utility.BubbleSortString(userArray));
            Console.Read();
        }
    }
}
