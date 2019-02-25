// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.HashingFunction
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets the prime numbers list.
        /// </summary>
        /// <returns> returns array of prime Numbers</returns>
        public static ArrayList GetPrimeNumbersList()
        {
            try
            {
                ArrayList primeNumberArrayList = new ArrayList();
                bool primeNumberFound = false; ////for checking if there is atleast one primeNumber between the given range;
                bool flag = true; //// to Print to console if a number is Prime.
                int initialNumber = 0;
                int lastNumber = 0;
                bool initialFlag = true;
                int indexForPrimeArray = 0;

                while (initialFlag)
                {
                    Console.WriteLine("Enter the Initial Range");
                    string strInitial = Console.ReadLine();

                    if (IsNumber(strInitial) == false)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    initialNumber = Convert.ToInt32(strInitial);

                    if (initialNumber < 0)
                    {
                        Console.WriteLine("Enter a number greater then 0");
                        continue;
                    }

                    initialFlag = false;
                }

                bool lastFlag = true; //// keep asking the user till valid number is given.
                while (lastFlag)
                {
                    Console.WriteLine("Enter the Last Number ,you want to print Prime Numbers till");
                    string strLast = Console.ReadLine();

                    if (IsNumber(strLast) == false)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    lastNumber = Convert.ToInt32(strLast);

                    if (lastNumber <= initialNumber)
                    {
                        Console.WriteLine("Last number should be greater than the initial Value ");
                        continue;
                    }

                    lastFlag = false;
                }

                //// For keep checking for PrimeNumber till last Range.
                for (int i = initialNumber; i <= lastNumber; i++)
                {
                    if (i == 2)
                    {
                        flag = true;
                    }

                    if (i % 2 == 0 && i != 2)
                    {
                        continue;
                    }

                    if (i == 1)
                    {
                        continue;
                    }

                    //// checking for divisibility for each odd number.
                    for (int j = 3; j < i; j = j + 2)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        primeNumberArrayList.Add(i);
                        indexForPrimeArray++;
                        primeNumberFound = true;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (primeNumberFound == false)
                {
                    Console.WriteLine("There are no Prime Numbers between range " + initialNumber + " & " + lastNumber);
                }

                return primeNumberArrayList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Gets the anagrams.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns> returns 2D array of string containing Anagrams</returns>
        /// <exception cref="Exception">throws Exception</exception>
        public static string[,] GetAnagrams(ArrayList list)
        {
            try
            {
                int rowForAnagram = 0;
                int columnForAnagram = 0;
                int rowForNotAnagram = 0;
                int columnForNotAnagram = 1;

                string[,] primeAnagram2DArray = new string[1000, 2];

                ////Here i points starts from the first element 
                for (int i = 0; i < list.Count; i++)
                {
                    //// Here the element at i is compared to each element at value of j.
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (j != i)
                        {
                            if (list[i].ToString().Length == list[j].ToString().Length)
                            {
                                if (CheckAnagram(list[i].ToString(), list[j].ToString()))
                                {
                                    primeAnagram2DArray[rowForAnagram, columnForAnagram] = string.Empty + list[i].ToString() + "is anagram of " + list[j].ToString();
                                    rowForAnagram++;
                                }
                                else
                                {
                                    if (j == list.Count)
                                    {
                                        primeAnagram2DArray[rowForNotAnagram, columnForNotAnagram] = list[i].ToString();
                                    }
                                }
                            }
                        }
                    }
                }

                return primeAnagram2DArray;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the anagram.
        /// </summary>
        /// <param name="s1">The s1.</param>
        /// <param name="s2">The s2.</param>
        /// <returns> returns true if given Anagram are true</returns>
        public static bool CheckAnagram(string s1, string s2)
        {
            try
            {
                char[] ca1 = s1.ToCharArray();
                char[] ca2 = s2.ToCharArray();
                Array.Sort(ca1);
                Array.Sort(ca2);

                string str1 = new string(ca1);
                string str2 = new string(ca2);

                if (str1.Equals(str2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
        /// Checks the string is empty or Null.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returns false if string is null or empty</returns>
        public static bool CheckString(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// returns true if string contain any special Character
        /// </summary>
        /// <param name="userName">Takes the username </param>
        /// <returns>returns  if string contains any Character </returns>
        public static bool ContainsCharacter(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                //// check each character in given string wheather it is a Character.
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        /// <param name="array">The array</param>
        public static void PrintMatrix(string[,] array)
        {
            try
            {
                var rowCount = array.GetLength(0);
                var colCount = array.GetLength(1);
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        if (array[row, col] != null && array[row, col].Trim() != string.Empty)
                        {
                            Console.WriteLine("  " + array[row, col] + "  ");
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
