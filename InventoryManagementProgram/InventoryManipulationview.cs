// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManipulationview.cs" company="Bridgelabz">
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
    /// Inventory Manipulation View
    /// </summary>
    public class InventoryManipulationView
    {
        /// <summary>
        /// Inventories the manipulation view.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public static void InventoryManipulationview(string inventoryType)
        {
            Console.WriteLine("Enter the Item Name you Want to Edit");
            string itemName = Console.ReadLine();

            if (inventoryType.Equals("RICE"))
            {
                if (Rice.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            if (inventoryType.Equals("WHEAT"))
            {
                if (Wheat.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            if (inventoryType.Equals("PULSES"))
            {
                if (Pulses.DoesObjectExist(itemName) == false)
                {
                    Console.WriteLine("item " + itemName + " does not exist");
                    return;
                }
            }

            Console.WriteLine("Choose what do you want to edit");
            Console.WriteLine("1) Name");
            Console.WriteLine("1) Weight");
            Console.WriteLine("1) Price Per Kg");
        }
    }
}
