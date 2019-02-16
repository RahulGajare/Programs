// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntBinarySearch.cs" company="Bridgelabz">
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
    /// Searches an Int using BinarySearch Method
    /// </summary>
    public class IntBinarySearch
    {
        /// <summary>
        /// Binaries the search int.
        /// </summary>
        public static void BinarySearchInt()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                int[] userArray = Utility.TakeInputIntArray();
                int numberToSearch = 0;
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter the int you want to search");
                    string strInt = Console.ReadLine();
                    if (Utility.IsNumber(strInt) == false)
                    {
                        Console.WriteLine("You can only search for an Int");
                    }

                    numberToSearch = Convert.ToInt32(strInt);
                    flag = false;
                }

                stopwatch.Start();
                if (Utility.BinarySearchInteger(userArray, numberToSearch) == false)
                {
                    Console.WriteLine("Does not contain int " + numberToSearch);
                }
                else
                {
                    stopwatch.Stop();
                    Console.WriteLine("found ");
                    Console.WriteLine("Elapsed time = " + stopwatch.Elapsed);       
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
