// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Triplets.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ----------------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Finds the triplet Whose sum equals to exact Zero.
    /// </summary>
    public class Triplets
    {
        /// <summary>
        /// Finds the triplet Whose sum equals to exact Zero.
        /// </summary>
        public static void FindTriplet()
        {
            try
            {
                int numberOfTripletFound = 0;
                int[] intArray = Utility.TakeInputIntArray();

                //// for the first Element in Array
                for (int i = 0; i < intArray.Length - 2; i++)
                {
                    ////for the second Element in Array
                    for (int j = i + 1; j < intArray.Length - 1; j++)
                    {
                        ////for the third Element in Array
                        for (int k = j + 1; k < intArray.Length; k++)
                        {
                            if (intArray[i] + intArray[j] + intArray[k] == 0)
                            {
                                Console.WriteLine(string.Empty + intArray[i] + intArray[j] + intArray[k] + " = 0");
                                Console.WriteLine();
                                numberOfTripletFound++;
                            }
                        }
                    }
                }

                Console.WriteLine("Number of Triplet found " + numberOfTripletFound);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }  
        }
    }
}
