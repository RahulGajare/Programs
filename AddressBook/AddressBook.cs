// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections;

    /// <summary>
    /// AddressBook Class
    /// </summary>
    public class AddressBook
    {
        private string addressBookName;
        private List<AddressDetails> addressDetailsList = new List<AddressDetails>();

        /// <summary>
        /// Gets or sets the address details.
        /// </summary>
        /// <value>
        /// The address details.
        /// </value>
        public List<AddressDetails> AddressDetailsList
        {
            get { return this.addressDetailsList; }
            set { this.addressDetailsList = value; }
        }

        /// <summary>
        /// Gets or sets the addressBookName.
        /// </summary>
        public string AddressBookName
        {
            get { return this.addressBookName; }
            set { this.addressBookName = value; }
        }

        /// <summary>
        /// assigns the address book name
        /// </summary>
        /// <param name="addressBookName"></param>
        public AddressBook(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }

        /// <summary>
        /// Creates new addressBook
        /// </summary>
        /// <param name="addressBookName"></param>
        public static void CreateAddressBook(string addressBookName)
        {
            AddressBook addressBook = new AddressBook(addressBookName);
            DataLogic.CreateAddressBookFile(addressBook);
        }

        /// <summary>
        /// Prints the existing Address books
        /// </summary>
        public static void PrintExistingAddressBook()
        {
            int optionNumber = 1;
            int addressBookOption = 0;
            List<string> fileNameList = DataLogic.GetAddressBookList();

            while (true)
            {
                Console.WriteLine("Choose an address book to Open");
                Console.WriteLine("0) To Go back");

                //// Removes the extension name from all files.
                foreach (string filename in fileNameList)
                {
                    Console.WriteLine(optionNumber + " ) " + filename.Replace(".json", ""));
                    optionNumber++;
                }

                optionNumber = 1;
                string stringaddressBookOption = Console.ReadLine();

                try
                {

                    addressBookOption = Convert.ToInt32(stringaddressBookOption);
                    if (addressBookOption == 0)
                    {
                        return;
                    }

                    GetBookName(addressBookOption);


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("-----------------------------------------------");
                    continue;
                }
            }


        }

        /// <summary>
        /// Tells which Book was Choosen by the user
        /// </summary>
        /// <param name="addressBookOption"></param>
        public static void GetBookName(int addressBookOption)
        {
            try
            {
                ////Getting the All the names of Existing book in list.
                List<string> fileNameList = DataLogic.GetAddressBookList();

                string bookName = fileNameList[addressBookOption - 1].Replace(".json", "");

                ////Calling the method that will ask the user what to do with choosen Book
                AddressBookView.AddressbookView(bookName);

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Prints All the Details inside the address Book
        /// </summary>
        /// <param name="addressBookName"></param>
        public static void PrintAddressBookDetails(string addressBookName)
        {
            AddressBook addressBook = DataLogic.GetBookDetails(addressBookName);

            List<AddressDetails> list = addressBook.addressDetailsList;

            //// Prints  details of all Persons in the addressBook
            foreach (AddressDetails address in list)
            {
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------------------");
            }
        }

        /// <summary>
        /// Prints the Only Details of given FirstName
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="firstName"></param>
        public static void PrintSingleAddresss(string bookName, string firstName)
        {
            AddressBook addressBook = DataLogic.GetBookDetails(bookName);

            List<AddressDetails> list = addressBook.addressDetailsList;

            ////prints only one person details if found.
            foreach (AddressDetails address in list)
            {
                if (address.FirstName.Equals(firstName))
                {
                    Console.WriteLine(address.ToString());
                    return;
                }
            }
        }

    }
}
