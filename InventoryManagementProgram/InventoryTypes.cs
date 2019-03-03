// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryTypes.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InventoryTypes Class
    /// </summary>
    public class InventoryTypes
    {
        private InventoryTypes inventoryTypes = new InventoryTypes();
        /// <summary>
        /// The rice list
        /// </summary>
        private List<Rice> riceList = new List<Rice>();

        /// <summary>
        /// The wheat list
        /// </summary>
        private List<Wheat> wheatList = new List<Wheat>();

        /// <summary>
        /// The pulses list
        /// </summary>
        private List<Pulses> pulsesList = new List<Pulses>();

        public InventoryTypes InventoryTypesObject
        {
            get { return this.inventoryTypes; }
            set { this.inventoryTypes = value; }
        }

        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<Rice> RiceList
        {
            get { return this.riceList; }
            set { this.riceList = value; }
        }

        /// <summary>
        /// Gets or sets the wheat list.
        /// </summary>
        /// <value>
        /// The wheat list.
        /// </value>
        public List<Wheat> WheatList
        {
            get { return this.wheatList; }
            set { this.wheatList = value; }
        }

        /// <summary>
        /// Gets or sets the pulses list.
        /// </summary>
        /// <value>
        /// The pulses list.
        /// </value>
        public List<Pulses> PulsesList
        {
            get { return this.pulsesList; }
            set { this.pulsesList = value; }
        }
    }
}
