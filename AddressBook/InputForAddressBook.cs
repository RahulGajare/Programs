using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.AddressBook
{
    class InputForAddressBook
    {
        public static string TakeInputForAddressBook()
        {
            string addressBookName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter a Name for Address Book");
                addressBookName = Console.ReadLine();

                if (Utility.CheckString(addressBookName))
                {
                    Console.WriteLine("You have to Specify a name");
                    continue;
                }

                
                if (Utility.ContainsCharacter(addressBookName))
                {
                    Console.WriteLine("No Special Characters allowed");
                    continue;
                }

                return addressBookName;

            }
        }
    
    }
}
