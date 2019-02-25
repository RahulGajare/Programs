// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.HashingFunction
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Hashing Function
    /// </summary>
    public class HashingFunction
    {
        /// <summary>
        /// Stores the Data using hashing
        /// </summary>
        /// <param name="fileData">The file data.</param>
        /// <param name="numberToSearch">The number to search.</param>
        /// <param name="filePath">The file path.</param>
        /// <exception cref="Exception">Handles and throws Exception</exception>
        public static void Hashingfunction(ArrayList fileData, int numberToSearch, string filePath)
        {
            try
            {
                SinglyLinkedList[] hashArray = new SinglyLinkedList[11];

                foreach (int number in fileData)
                {
                    int remainder = number % 11;
                    if (hashArray[remainder] == null)
                    {
                        hashArray[remainder] = new SinglyLinkedList();
                        hashArray[remainder].Add(number);
                    }
                    else
                    {
                        hashArray[remainder].Add(number);
                    }
                }

                for (int i = 0; i < hashArray.Length; i++)
                {
                    if (hashArray[i] != null)
                    {
                        if (hashArray[i].Contains(numberToSearch))
                        {
                            hashArray[i].Delete(numberToSearch);

                            break;
                        }
                    }
                }

                for (int i = 0; i < hashArray.Length; i++)
                {
                    if (hashArray[i] != null)
                    {
                        hashArray[i].WriteToFile(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
