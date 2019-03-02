﻿// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP
{
    using OOP.AddressBook;
    using OOP.DeckOfCards;
    using OOP.Commercial_Data_Processing;
    using OOP.InventoryDetails;
    using OOP.RegexReplace;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Entry Point of this Project
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
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
                    Console.WriteLine("1) Inventory data Managament");
                    Console.WriteLine("2) Regex Replacment");
                    Console.WriteLine("3) Deck Of Cards");
                    Console.WriteLine("4) Stock Report");
                    Console.WriteLine("5) Commercial Data Processing");
                    Console.WriteLine("6) Address Book");

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
                                InventoryManager.GetInventoryList();
                                break;
                            }

                        case 2:
                            {
                                UserInfo.TakeUserInfo();
                                break;
                            }

                        case 3:
                            {
                                OOP.DeckOfCards.DeckOfCards deck = new DeckOfCards.DeckOfCards();
                                deck.InitializeDeckOfCards();
                                break;
                            }

                        case 4:
                            {
                                StockReport.ReadJson.Readjsonfile();
                                break;
                            }

                        case 5:
                            {
                                StartCommercial.InitialiseShares();
                                break;
                            }

                        case 6:
                            {
                                StartAppView.InitialiseAddressBook();
                                break;
                            }

                        case 7:
                            {                                
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
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }
    }
}
