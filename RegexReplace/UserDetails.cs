using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.RegexReplace
{
    class UserDetails
    {
        private string name;
        private string fullName;
        private string contactNumber;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string ContactNumber
        {
            get { return this.contactNumber; }
            set { this.contactNumber = value; }
        }
    }
}
