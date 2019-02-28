using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOP.AddressBook
{
    class AddressBook
    {
        private ArrayList addressDetails;


        public ArrayList AddressDetails
        {
            get { return this.addressDetails; }
            set { this.addressDetails = value; }
        }


    }
}
