// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
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
    /// InventoryManager Class
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// Gets the inventory list.
        /// </summary>
        public static void GetInventoryList(string inventoryType)
        {
            List<Rice> riceList = null;
            List<Wheat> wheatList = null;
            List<Pulses> pulsesList = null;
            InventoryDetails inventoryDetail = InventoryFactory.ReadJsonFile();
            List<InventoryTypes> inventoryTypesList = inventoryDetail.InventoryDetailsList;
            

            foreach (InventoryTypes inventoryTypes in inventoryTypesList)
            {

                riceList = inventoryTypes.RiceList;
                wheatList = inventoryTypes.WheatList;
                pulsesList = inventoryTypes.PulsesList;

            }
            if (inventoryType.Equals("RICE"))
            {
                foreach (Rice rice in riceList)
                {
                    Console.WriteLine("Rice type");
                    Console.WriteLine("Name : " + rice.Name + "\nWeight : " + rice.Weight + "\nPrice per Kg : " + rice.PricePerKg);
                    Console.WriteLine("Total price of " + rice.Name + " = " + (rice.Weight * rice.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }

                return;
            }


            if (inventoryType.Equals("WHEAT"))
            {
                foreach (Wheat wheat in wheatList)
                {
                    Console.WriteLine("Wheat type");
                    Console.WriteLine("Name : " + wheat.Name + "\nWeight : " + wheat.Weight + "\nPrice per Kg : " + wheat.PricePerKg);
                    Console.WriteLine("Total price of " + wheat.Name + " = " + (wheat.Weight * wheat.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }
                return;
            }


            if (inventoryType.Equals("PULSES"))
            {
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
