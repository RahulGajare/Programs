// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="CountBinaryTrees.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Number_Of_BinaryTrees
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Count Binary tree Class
    /// </summary>
    public class CountBinaryTrees
    {
        /// <summary>
        /// Counts the binary tree.
        /// </summary>
        /// <param name="numberOfElements">The number of elements.</param>
        /// <returns> returns the Count of Binary trees</returns>
        public static int CountBinaryTree(int numberOfElements)
        {
            try
            {
                int numerator = 0;
                int denominator = 0;

                numerator = FindFactorial(2 * numberOfElements);
                denominator = FindFactorial(numberOfElements + 1) * FindFactorial(numberOfElements);

                return numerator / denominator;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// returns the factorial of given Number
        /// </summary>
        /// <param name="number">takes int</param>
        /// <returns>returns the factorial</returns>
        public static int FindFactorial(int number)
        {
            try
            {
                int factorial = number;

                while (number > 1)
                {
                    factorial = factorial * (number - 1);
                    number--;
                }

                return factorial;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }
    }
}
