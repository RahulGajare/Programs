// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// Consist of Utility Method
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
            if (string.IsNullOrEmpty(name.Trim()))
            {       
                return true;
            }
            else
            {
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
            if (input.Trim().Equals(string.Empty))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Use this method to take inputs in an Int userArray , this method takes care of all validations for wrong inputs other than Int and
        /// return the Int stringArray.
        /// </summary>
        /// <returns>int stringArray</returns>
        public static int[] TakeInputIntArray()
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

        /// <summary>
        /// Takes the input  for string array.
        /// </summary>
        /// <returns> returns filled string Array</returns>
        public static string[] TakeInputStringArray()
        {
            string[] stringArray = new string[0];
            int numberOfStrings = 0;
            bool flag = true; //// for keepasking the inputs untill correct Integers is given.
            while (flag)
            {
                Console.WriteLine("Enter the Numbers of strings you want to Enter");
                string strNumberOfStrings = Console.ReadLine();

                if (Utility.IsNumber(strNumberOfStrings) == false)
                {
                    Console.WriteLine("Enter Only integers");
                    continue;
                }
                else
                {
                    numberOfStrings = Convert.ToInt32(strNumberOfStrings);
                    stringArray = new string[numberOfStrings];
                    flag = false;
                }
            }

            Console.WriteLine("Enter the Strings One by one");
            for (int i = 0; i < numberOfStrings; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            return stringArray;
        }

        /// <summary>
        /// Prints given userArray
        /// </summary>
        /// <param name="array"> int []</param>
        public static void PrintArrayInt(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {                 
                        Console.Write(array[i] + " ");           
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        /// <summary>
        /// Prints the array string.
        /// </summary>
        /// <param name="userArray">The user array.</param>
        public static void PrintArrayString(string[] userArray)
        {
            try
            {
                for (int i = 0; i < userArray.Length; i++)
                {
                    Console.Write(userArray[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
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

        /// <summary>
        /// Gets the prime numbers list.
        /// </summary>
        /// <returns> returns array of prime Numbers</returns>
        public static ArrayList GetPrimeNumbersList()
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

            bool lastFlag = true;
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

        /// <summary>
        /// Prints the userArray list.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void PrintArrayList(ArrayList list)
        {
            foreach (var i in list)
            {
                if (i != null)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Prints the anagrams from given ArrayList.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void PrintAnagrams(ArrayList list)
        {
            bool found = false; //// To check if atleast One Palindrome is found.

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
                                found = true;
                                Console.WriteLine(list[i].ToString() + "is anagram of " + list[j].ToString());
                            }
                        }                   
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine("No Anagram found in given range");
                Console.WriteLine("==========================================================================");
            }
        }

        /// <summary>
        /// Checks the palindrome.
        /// </summary>
        /// <param name="userString">The user string.</param>
        /// <returns>returns true if given string is Palindrome</returns>
        public static bool CheckPalindrome(string userString)
        {
            char[] userstringCharArray = userString.ToCharArray();           
            for (int i = 0; i < userstringCharArray.Length / 2; i++)
            {
                int j = userstringCharArray.Length - 1 - i;

                userstringCharArray[i] = (char)(userstringCharArray[i] ^ userstringCharArray[j]);
                userstringCharArray[j] = (char)(userstringCharArray[i] ^ userstringCharArray[j]);
                userstringCharArray[i] = (char)(userstringCharArray[i] ^ userstringCharArray[j]);
            }

            if (new string(userstringCharArray).Equals(userString))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Prints the prime palindrome.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void PrintPrimePalindrome(ArrayList list)
        {
            bool found = false; //// To check if atleast One Palindrome is found.
            foreach (int i in list)
            {
                if (CheckPalindrome(i.ToString()))
                {                
                    Console.WriteLine(i);
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("NO Palindrom prime Numbers found in given range");
                Console.WriteLine("=======================================================================");
            }
        }

        /// <summary>
        /// Bubbles sorts the given int stringArray.
        /// </summary>
        /// <param name="userArray">The user userArray.</param>
        /// <returns>returns sorted  int array</returns>
        public static int[] BubbleSortInt(int[] userArray)
        {
            for (int i = 0; i <= userArray.Length - 1; i++)
            {
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[i] > userArray[j])
                    {
                        userArray[i] = (char)(userArray[i] ^ userArray[j]);
                        userArray[j] = (char)(userArray[i] ^ userArray[j]);
                        userArray[i] = (char)(userArray[i] ^ userArray[j]);
                    }
                }
            }

            return userArray;
        }

        /// <summary>
        /// Bubbles the sort string.
        /// </summary>
        /// <param name="userArray">The user array.</param>
        /// <returns> returns sorted string</returns>
        public static string[] BubbleSortString(string[] userArray)
        {
            for (int i = 0; i <= userArray.Length - 1; i++)
            {
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[i].CompareTo(userArray[j]) > 0)
                    {
                        string temp = userArray[i];
                        userArray[i] = userArray[j];
                        userArray[j] = temp;
                    }
                }
            }

            return userArray;
        }

        /// <summary>
        /// Searches an given Integer using Binary search method
        /// </summary>
        /// <param name="userArray">The user array.</param>
        /// <param name="search">The search.</param>
        /// <returns> Returns true if found</returns>
        public static bool BinarySearchInteger(int[] userArray, int search)
        {
            Array.Sort(userArray);
            int first = 0;
            int last = userArray.Length - 1;
            int middle = (first + last) / 2;

            while (first <= last)
            {
                if (userArray[middle] < search)
                {
                    first = middle + 1;
                }
                else if (userArray[middle] == search)
                {
                    return true;
                }
                else
                {
                    last = middle - 1;
                }

                middle = (first + last) / 2;
            }

            return false;
        }

        /// <summary>
        /// Searches an given string using Binary search method
        /// </summary>
        /// <param name="userArray">The user array.</param>
        /// <param name="search">The search.</param>
        /// <returns> returns found</returns>
        public static bool BinarySearchString(string[] userArray, string search)
        {
            Array.Sort(userArray);
            int first = 0;
            int last = userArray.Length - 1;
            int middle = (first + last) / 2;

            while (first <= last)
            {
                if (userArray[middle].CompareTo(search) < 0)
                {
                    first = middle + 1;
                }
                else if (userArray[middle].Equals(search))
                {
                    return true;
                }
                else
                {
                    last = middle - 1;
                }

                middle = (first + last) / 2;
            }

            return false;
        }

        /// <summary>
        /// Celsius to fahrenheit.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <returns> Celsius To Fahrenheit </returns>
        public static int CelsiusToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Fahrenheits to celsius.
        /// </summary>
        /// <param name="fahrenheit">The fahrenheit.</param>
        /// <returns> returns Celsius value</returns>
        public static int FahrenheitToCelsius(int fahrenheit)
        {
            return (fahrenheit - 32) * (5 / 9);
        }

        /// <summary>
        /// Insertions the sort int.
        /// </summary>
        /// <param name="userArray">The user array.</param>
        /// <returns>sorted int Array</returns>
        public static int[] InsertionSortInt(int[] userArray)
        {
            int hold;
            for (int i = 1; i < userArray.Length; i++)
            {
                hold = userArray[i];
                int j = i;
                while (j > 0 && userArray[j - 1] > hold)
                {
                    userArray[j] = userArray[j - 1];
                    j--;
                }

                userArray[j] = hold;        
            }

            return userArray;
        }

        /// <summary>
        /// Insertions the sort string.
        /// </summary>
        /// <param name="userArray">The user array.</param>
        /// <returns> sorted String Array</returns>
        public static string[] InsertionSortString(string[] userArray)
        {
            string hold;
            for (int i = 1; i < userArray.Length; i++)
            {
                hold = userArray[i];
                int j = i;
                while (j > 0 && userArray[j - 1].CompareTo(hold) > 0)
                {
                    userArray[j] = userArray[j - 1];
                    j--;
                }

                userArray[j] = hold;
            }

            return userArray;
        }
    }
}