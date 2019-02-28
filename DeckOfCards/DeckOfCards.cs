using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DeckOfCards
{
    class DeckOfCards
    {
        int[,] deckOfCards = new int[4, 13];
        Random random = new Random();
         int player = 1;

        public void InitializeDeckOfCards()
        {         
            ////loops 1 time for all 4 players.
            for (int playerNumber = 1; playerNumber <= 4; playerNumber++)
            {
                Distribute9Cards(playerNumber);
                Console.WriteLine("Player " + player);
                player++;
                Console.WriteLine("=============");
                print(playerNumber);
                Console.WriteLine("==============");
            }
            

        }

        public void Distribute9Cards(int playerNumber)
        {
            //// loops 9 times for each player so as to give 9 cards to each
            for (int i = 0; i < 9; i++)
            {
                ShuffleCards(playerNumber);
            }
        }

        public void ShuffleCards(int playerNumber)
        {
            int suit = this.random.Next(1,4);
            int rank = this.random.Next(1,13);
            if (deckOfCards[suit, rank] == 0)
            {
                deckOfCards[suit, rank] = playerNumber;
                return;
            }
            else
            {
                ShuffleCards(playerNumber);
            }          
        }

        public void print(int playerNumber)
        {
           int suitLength = deckOfCards.GetLength(0);
           int rankLength = deckOfCards.GetLength(1);
            for (int suits= 0; suits < suitLength; suits++)
            {
                for (int ranks = 0; ranks<rankLength; ranks++)
                {
                    if(deckOfCards[suits,ranks] == playerNumber)
                    {
                        Console.WriteLine(GetSuit(suits) + " " + GetRank(ranks));                        
                    }                
                }
            }            
        }

        public static string GetSuit(int suits)
        {
            switch (suits)
            {
                case 0:
                    {
                        return "clubs";
                        
                    }

                case 1:
                    {
                        return "Diamond";
                        
                    }

                case 2:
                    {
                        return "Heart";
                        
                    }

                case 3:
                    {
                        return "Spade";
                        
                    }
                default:
                    {
                        return "In switch (default)";
                        
                    }
            }
        }

        public static string GetRank(int rank)
        {
            switch (rank)
            {
                case 0:
                    {
                        return "2";
                    }
                case 1:
                    {
                        return "3";
                    }
                case 2:
                    {
                        return "4";
                    }
                case 3:
                    {
                        return "5";
                    }
                case 4:
                    {
                        return "6";
                    }
                case 5:
                    {
                        return "7";
                    }
                case 6:
                    {
                        return "8";
                    }
                case 7:
                    {
                        return "9";
                    }
                case 8:
                    {
                        return "10";
                    }
                case 9:
                    {
                        return "Jack";
                    }
                case 10:
                    {
                        return "Queen";
                    }
                case 11:
                    {
                        return "King";
                    }
                case 12:
                    {
                        return "Ace";
                    }
                default:
                    {
                        return string.Empty;
                    }
               
            }
        }

    }
}
