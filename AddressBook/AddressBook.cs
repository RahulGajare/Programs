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
        private List <AddressDetails> addressDetailsList = new List<AddressDetails>();

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

        public string AddressBookName
        { get { return this.addressBookName; }
            set { this.addressBookName = value; }
        }

        public AddressBook(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }

        public static void CreateAddressBook(string addressBookName)
        {
            AddressBook addressBook = new AddressBook(addressBookName);
            DataLogic.CreateAddressBookFile(addressBook);
        }


        public static void PrintExistingAddressBook()
        {
            int optionNumber = 1;
            int addressBookOption = 0;
            List<string> fileNameList = DataLogic.GetAddressBookList();

            while (true)
            {
                Console.WriteLine("Choose an address book to Open");
                Console.WriteLine("0) To Go back");

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


        public static void GetBookName(int addressBookOption)
        {
            try
            {

                List<string> fileNameList = DataLogic.GetAddressBookList();

                string bookName = fileNameList[addressBookOption-1].Replace(".json","");

                ////Calling the method that will ask the user what to do with choosen Book
                AddressBookView.AddressbookView(bookName);

                AddressBook addressBook = DataLogic.GetBookDetails(bookName);
            
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("-----------------------------------------------");
                
            }
        }


        public static void PrintAddressBookDetails(AddressBook addressBook)
        {
            List<AddressDetails> addressListDetails = addressBook.addressDetailsList;

            foreach (AddressDetails details in addressListDetails)
            {
                Console.WriteLine(details.FirstName + " " + details.LastName);
            }
        }



    }
}
