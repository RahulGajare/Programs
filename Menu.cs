using OOP.DeckOfCards;
using OOP.InventoryDetails;
using OOP.RegexReplace;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Menu
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
                    Console.WriteLine("1) Inventory data Managament");
                    Console.WriteLine("2) Regex Replacment");
                    Console.WriteLine("3) Deck Of Cards");

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
                                ReadJson.ReadJsonFile();
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
                                
                                break;
                            }

                        case 5:
                            {
                                
                                break;
                            }

                        case 6:
                            {
                               
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
