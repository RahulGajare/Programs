// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// To convert number to Binary
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// Converts to binary.
        /// </summary>
        public static void ConvertToBinary()
        {
            ArrayList binaryArrayList = new ArrayList();
            string binary = string.Empty;

            int userNumber = 0;
            bool loopNumber = true;

            while (loopNumber)
            {
                Console.WriteLine("Enter the Number");
                string stringUserNumber = Console.ReadLine();

                if (Utility.IsNumber(stringUserNumber) == false)
                {
                    Console.WriteLine("Enter a valid Positive Integer");
                    continue;
                }

                userNumber = Convert.ToInt32(stringUserNumber);
                loopNumber = false;
            }
      
            while (userNumber > 0)
            {
                binary = binary + (userNumber % 2).ToString();
                userNumber = userNumber / 2;
            }

            char[] binaryCharArray = binary.ToCharArray();

            for (int i = binaryCharArray.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryCharArray[i]);
            }

            Console.WriteLine();
        }
    }
}
