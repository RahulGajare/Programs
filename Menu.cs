// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Entry point of this project
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <exception cref="Exception">throws exception</exception>
        public static void Main()
        {
            try
            {
                int option = -1; ////option for choosing a number from menu.
                bool flag = true; ////flag for keep looping untill a valid option from the existing menu is choose.
                while (flag)
                {
                    Console.WriteLine("======================================================================================================================");
                    Console.WriteLine("Select the program from below .Enter 0 to exit");
                    Console.WriteLine("1) Anagram");
                    Console.WriteLine("2) PrintPrimeNUmbers");
                    Console.WriteLine("3) Prime Anagram");
                    Console.WriteLine("4) Prime palindrome");
                    Console.WriteLine("5) string Binary Search");
                    Console.WriteLine("6) Integer Binary search");
                    Console.WriteLine("7) String Bubble sort");
                    Console.WriteLine("8) Integer Bubble sort");
                    Console.WriteLine("9) Temperature Conversion");
                    Console.WriteLine("10) Convert to Binary");
                    Console.WriteLine("11) Integer Insertion sort");
                    Console.WriteLine("12) String Insertion sort");
                    Console.WriteLine("13) Vending Machine");
                    Console.WriteLine("14) Find square root");
                    Console.WriteLine("15) SwapNibble");
                
                    Console.WriteLine("======================================================================================================================");

                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Command");
                        continue;
                    }

                    switch (option)
                    {
                        case 0:
                            {
                                flag = false;
                                break;
                            }

                        case 1:
                            {
                                Anagram.AnagramString();
                                break;
                            }

                        case 2:
                            {
                                PrimeNumbers.PrintPrimeNumber();
                                break;
                            }

                        case 3:
                            {
                                PrimeAnagram.PrintPrimeAnagram();
                                break;
                            }

                        case 4:
                            {
                                PrimePalindrome.PrimePalindromes();
                                break;
                            }

                        case 5:
                            {
                                StringBinarySearch.BinarySearchString();
                                break;
                            }

                        case 6:
                            {
                                IntBinarySearch.BinarySearchInt();
                                break;
                            }

                        case 7:
                            {
                                StringBubbleSort.Stringbubblesort();
                                break;
                            }

                        case 8:
                            {
                                IntBinarySearch.BinarySearchInt();
                                break;
                            }

                        case 9:
                            {
                                Temperatureconversion.ConvertTemp();
                                break;
                            }

                        case 10:
                            {
                                ToBinary.ConvertToBinary();
                                break;
                            }

                        case 11:
                            {
                                InsertionSortInteger.IntegerInsertionSort();
                                break;
                            }

                        case 12:
                            {
                                InsertionSortString.StringInsertionSort();
                                break;
                            }

                        case 13:
                            {
                                VendingMachine.Vendingmachine();
                                break;
                            }

                        case 14:
                            {
                                Sqrt.FindSqrt();
                                break;
                            }

                        case 15:
                            {
                                SwapNibble.SwapNibbles();
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }
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
