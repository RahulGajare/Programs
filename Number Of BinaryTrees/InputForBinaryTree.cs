// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForBinaryTree.cs" company="Bridgelabz">
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
    /// Input for Binary
    /// </summary>
    public class InputForBinaryTree
    {
        /// <summary>
        /// Binaries the tree.
        /// </summary>
        public static void BinaryTree()
        {
            int numberOfElements = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter the Number Of Elements");
                string stringElements = Console.ReadLine();

                if (Utility.IsNumber(stringElements) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }            

                numberOfElements = Convert.ToInt32(stringElements);

                if (numberOfElements < 0)
                {
                    Console.WriteLine("the Number of elements should be greater than 0");
                    continue;
                }

                loop = false;
            }

           int numberOfBinaryTrees = CountBinaryTrees.CountBinaryTree(numberOfElements);
            Console.WriteLine("Number Of Binary trees possible = " + numberOfBinaryTrees);
        }
    }
}
