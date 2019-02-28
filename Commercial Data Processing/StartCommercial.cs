using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Commercial_Data_Processing
{
    class StartCommercial
    {
        public static void InitialiseShares()
        {
            StockAccount stockAccount = new StockAccount();
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1) To buy Share");
                Console.WriteLine("2) To Sell a Share");
                Console.WriteLine("3) To view Existing Shares");
             
                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);
                


                switch (option)
                {
                    case 1:
                        {
                            UserInput.TakeUserInput(option);
                            break;
                        }

                    case 2:
                        {
                            UserInput.TakeUserInput(option);
                            break;
                        }

                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
               
               
            }
        }
    }
}
