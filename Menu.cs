
using DataStructures.BalancedParenthses;
using DataStructures.BankingCashCounter;
using DataStructures.LinkedList_Ordered_;
using DataStructures.LinkedList_UnOrdered_;
using DataStructures.PalindromChecker;
using DataStructures.Calendar;
using DataStructures.PrimeNumberIn2DArray;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
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
                    Console.WriteLine("6) Calendar");
                    Console.WriteLine("7) PrimeNumber in 2D array");

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
                                InputForCalendar.StartCalendar();
                                break;
                            }

                        case 7:
                            {
                                _2DArrayPrimeNumber._2DArray();
                                break;
                            }

                        case 8:
                            {
                                
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
