// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForAddressBook.cs" company="Bridgelabz">
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
    /// Input For AddressBook
    /// </summary>
    public class InputForAddressBook
    {
        /// <summary>
        /// Takes the input for address book.
        /// </summary>
        /// <returns>returns string</returns>
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
