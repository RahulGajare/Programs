using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.AddressBook
{
    class AddressBookView
    {
        public static void AddressbookView(string bookName)
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("press 1) To Open the BookDetails");
                Console.WriteLine("Press 2) To Add Address");
                Console.WriteLine("Press 3) To Edit an Address");

                string stringOption = Console.ReadLine();

                try
                {
                    option = Convert.ToInt32(stringOption);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                

                switch (option)
                {
                    case 1:
                        {

                            break;
                        }

                    case 2:
                        {
                            InputForAddressDetails.TakeInputForAddress(bookName);
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
