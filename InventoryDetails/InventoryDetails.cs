// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDetails.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventoryDetails Class
    /// </summary>
    public class InventoryDetails
    {
        /// <summary>
        /// The inventory details list
        /// </summary>
        private List<InventoryTypes> inventoryDetailsList = new List<InventoryTypes>();

        /// <summary>
        /// Gets or sets the inventory details list.
        /// </summary>
        /// <value>
        /// The inventory details list.
        /// </value>
        public List<InventoryTypes> InventoryDetailsList
        {
            get { return this.inventoryDetailsList; }
            set { this.inventoryDetailsList = value; }
        }
    }
}
