// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StartApp.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StartApp Class
    /// </summary>
    public class StartAppView
    {
        /// <summary>
        /// Initialises the address book.
        /// </summary>
        public static void InitialiseAddressBook()
        {
            int option = 0;
           
            while (true)
            {
                Console.WriteLine("choose an option");
                Console.WriteLine("1) View Existing Address Book");
                Console.WriteLine("2) Create new Address  book");
                Console.WriteLine("3) To Exit ");
                string stringOption = Console.ReadLine();

                if (Utility.CheckString(stringOption))
                {
                    Console.WriteLine("Invalid Option choosen");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                switch (option)
                {
                    case 1:
                        {
                            AddressBook.PrintExistingAddressBook();
                            break;
                        }

                    case 2:
                        {
                            string addressBookname = InputForAddressBook.TakeInputForAddressBook();
                            AddressBook.CreateAddressBook(addressBookname);
                            break;
                        }

                    case 3:
                        {

                            return; 
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
