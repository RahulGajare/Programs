﻿// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.RegexReplace
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// User Details Class
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The full name
        /// </summary>
        private string fullName;

        /// <summary>
        /// The contact number
        /// </summary>
        private string contactNumber;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        public string ContactNumber
        {
            get { return this.contactNumber; }
            set { this.contactNumber = value; }
        }
    }
}
