// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ------
namespace FunctionalPrograms
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Utility class has methods that are required to use multiple times. 
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Checks the string is empty or Null.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returns false if string is null or empty</returns>
        public static bool CheckString(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cant be empty, Enter proper name");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Use this method to take inputs in an Int array , this method takes care of all validations for wrong inputs other than Int and
        /// return the Int Array.
        /// </summary>
        /// <returns>int Array</returns>
        public static int[] TakeInputIntArray()
        {
            try
            {
                int[] numberArray = new int[0];
                bool flag = true; //// for keepasking the inputs untill correct Integers is given.
                while (flag)
                {
                    Console.WriteLine("Enter the Numbers of digits");
                    string strNumberOfDigits = Console.ReadLine();

                    if (Utility.IsNumber(strNumberOfDigits) == false)
                    {
                        Console.WriteLine("Enter Only integers");
                        continue;
                    }
                    else
                    {
                        int numberOfDigits = Convert.ToInt32(strNumberOfDigits);
                        numberArray = new int[numberOfDigits];

                        bool flag2 = true;
                    Loop: //// this lable for goto outside the for loop below.
                        while (flag2)
                        {
                            Console.WriteLine("Enter the Numbers one by one");
                            for (int i = 0; i < numberOfDigits; i++)
                            {
                                string strNumber = Console.ReadLine();
                                if (Utility.IsNumber(strNumber) == false)
                                {
                                    Console.WriteLine("You can only add integers");
                                    goto Loop;
                                }
                                else
                                {
                                    numberArray[i] = Convert.ToInt32(strNumber);
                                }
                            }

                            flag2 = false;
                            flag = false;
                        }
                    }
                }

                return numberArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new int[0];
            }
        }

        /// <summary>
        /// Gives the elapsed time between start and stop of stopwatch
        /// </summary>
        public static void StartStopWatch()
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Console.WriteLine("Stopwatch Started,Press Enter key to stop");
                Console.ReadKey();
                Console.WriteLine("Total Elapsed time = " + stopWatch.Elapsed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

      /// <summary>
      /// Prints given array
      /// </summary>
      /// <param name="array"> int []</param>
        public static void PrintArray(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    } 
}
