// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
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
    /// InventoryManager Class
    /// </summary>
    public class Inventorymanager
    {
        /// <summary>
        /// Gets the inventory list.
        /// </summary>
        public static void GetInventoryList()
        {
            ////Getting Inventory Objects from Inventory Factory.
            InventoryDetails inventoryDetail = InventoryFactory.ReadJsonFile();

            foreach (InventoryTypes inventoryTypes in inventoryDetail.InventoryDetailsList)
            {
                List<Rice> riceList = inventoryTypes.RiceList;
                List<Wheat> wheatList = inventoryTypes.WheatList;
                List<Pulses> pulsesList = inventoryTypes.PulsesList;
               
                foreach (Rice rice in riceList)
                {
                    Console.WriteLine("Rice type");
                    Console.WriteLine("Name : " + rice.Name + " \nWeight : " + rice.Weight + "\nPrice per Kg : " + rice.PricePerKg);
                    Console.WriteLine("Total price of " + rice.Name + " = " + (rice.Weight * rice.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }
             
                foreach (Wheat wheat in wheatList)
                {
                    Console.WriteLine("Wheat type");
                    Console.WriteLine("Name : " + wheat.Name + "\nWeight : " + wheat.Weight + "\nPrice per Kg : " + wheat.PricePerKg);
                    Console.WriteLine("Total price of " + wheat.Name + " = " + (wheat.Weight * wheat.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }
               
                foreach (Pulses pulse in pulsesList)
                {
                    Console.WriteLine("Pulse type");
                    Console.WriteLine("Name : " + pulse.Name + "\nWeight : " + pulse.Weight + "\nPrice per Kg : " + pulse.PricePerKg);
                    Console.WriteLine("Total price of " + pulse.Name + " = " + (pulse.Weight * pulse.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }
            }         
        }
    }
}
