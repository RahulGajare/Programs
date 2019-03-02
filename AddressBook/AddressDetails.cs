// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressDetails.cs" company="Bridgelabz">
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
    /// Person  Class
    /// </summary>
    public class AddressDetails
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// The zip
        /// </summary>
        private string zip;

        /// <summary>
        /// The phone number
        /// </summary>
        private string phoneNumber;

        public AddressDetails(string firstName, string lastName, string address, string city, string state, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
        }
       
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        /// <summary>
        /// Adds the person.
        /// </summary>
        public static void CreateAddressDetails(string bookName,string firstName, string lastName , string address, string city, string state, string phoneNumber)
        {
            AddressDetails addressDetails = new AddressDetails(firstName,lastName,address,city,state,phoneNumber);
            AddressBook addressBook = DataLogic.GetBookDetails(bookName);
            addressBook.AddressDetailsList.Add(addressDetails);
            DataLogic.WriteAddressBookToFile(addressBook);
            Console.WriteLine("Added to AddressBook "+bookName);
        }

        public override string ToString()
        {
            return "Name : " + this.FirstName + " " + this.LastName + "\nAddress : " + this.Address + "\nCity : " + this.City + "\nState : " + this.State + "\nZip  : " + this.Zip + "\nPhone Number : " + this.phoneNumber;
        }




    }
}
