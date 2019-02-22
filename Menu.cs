// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using DataStructures.BalancedParenthses;
    using DataStructures.BankingCashCounter;
    using DataStructures.LinkedList_Ordered_;
    using DataStructures.LinkedList_UnOrdered_;
    using DataStructures.PalindromChecker;
    using DataStructures.Calendar;
    using DataStructures.PrimeNumberIn2DArray;
    using DataStructures.PrimeAnagrams;
    using DataStructures.CalendarQueue;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Entery Point of this project
    /// </summary>
    public class Menu
    {
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
                    Console.WriteLine("1) Unordered LinkedList");
                    Console.WriteLine("2) Ordered LinkedList");
                    Console.WriteLine("3) Balanced Parentheses");
                    Console.WriteLine("4) Banking cash Counter");
                    Console.WriteLine("5) Palindrome Checker using Deque");
                    Console.WriteLine("6) PrimeAnagrams in 2D array");                       
                    Console.WriteLine("7) PrimeNumber in 2D array");
                    Console.WriteLine("8) Calendar by Queue");

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
                                InputForUnordered.UnOrderedList(); 
                                break;
                            }

                        case 2:
                            {
                                InputForOrdered.OrderedLinkedList();
                                break;
                            }

                        case 3:
                            {
                                InputForParentheses.CheckParentheses();
                                break;
                            }

                        case 4:
                            {
                                InputForCashCounter.Counter();
                                break;
                            }

                        case 5:
                            {
                                InputForPalindrome.CheckPalindrome();
                                break;
                            }

                        case 6:
                            {
                                _2DPrimeAnagrams.Print2DPrimeAnagram();
                                break;
                            }

                        case 7:
                            {
                                _2DArrayPrimeNumber._2DArray();
                                break;
                            }

                        case 8:
                            {
                                InputForCalendarQueue.StartCalendar();
                                break;
                            }

                        case 9:
                            {
                                
                                break;
                            }

                        case 10:
                            {
                                
                                break;
                            }

                        case 11:
                            {
                                
                                break;
                            }

                        case 12:
                            {
                                
                                break;
                            }

                        case 13:
                            {
                                
                                break;
                            }

                        case 14:
                            {
                                
                                break;
                            }

                        case 15:
                            {
                                
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
