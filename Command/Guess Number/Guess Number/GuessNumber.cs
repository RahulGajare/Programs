// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GuessNumber.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Guess_Number
{
    using System;

    /// <summary>
    /// Guesses the user number
    /// </summary>
    public class GuessNumber
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int[] intArray = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    intArray[i] = Convert.ToInt32(args[i]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Insert correct Numbers");
                    Console.Read();
                    return;
                }
            }

            BinarySearchInteger(intArray);
        }

        /// <summary>
        /// Binaries the search integer.
        /// </summary>
        /// <param name="userArray">The user array.</param>
        public static void BinarySearchInteger(int[] userArray)
        {
            try
            {
                string userResponse; //// to Store the user response either Y/N
                Array.Sort(userArray);
                int first = 0;
                int last = userArray.Length - 1;
                int middle = (first + last) / 2;

                while (true)
                {
                    Console.WriteLine("Is your Number " + userArray[middle] + " Enter Y/N");
                    userResponse = Console.ReadLine();

                    if (userResponse.Equals("Y"))
                    {
                        return;
                    }


                    Console.WriteLine("Is your Number greater than " + userArray[middle] + " Enter Y/N");
                    userResponse = Console.ReadLine();



                    if (userResponse.Equals("Y"))
                    {
                        first = middle + 1;
                    }
                    else
                    {
                        last = middle - 1;
                    }

                    middle = (first + last) / 2;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
