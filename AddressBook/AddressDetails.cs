using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.AddressBook
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public void AddPerson()
        {

        }


    }
}
