// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateObject.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// CreateObject Class
    /// </summary>
    public class CreateObject
    {
        /// <summary>
        /// Creates the objects.
        /// </summary>
        public static void CreateObjects()
        {
            Rice rice1 = new Rice();
            rice1.Name = "Basmati";
            rice1.PricePerKg = 50;
            rice1.Weight = 40;

            Rice rice2 = new Rice();
            rice2.Name = "Brown riceList";
            rice2.PricePerKg = 60;
            rice2.Weight = 30;

            Rice rice3 = new Rice();
            rice3.Name = "Green RiceList";
            rice3.PricePerKg = 25;
            rice3.Weight = 100;

            InventoryTypes inventoryTypes1 = new InventoryTypes();
            inventoryTypes1.RiceList.Add(rice1);
            inventoryTypes1.RiceList.Add(rice2);
            inventoryTypes1.RiceList.Add(rice3);

            Wheat wheat1 = new Wheat();
            wheat1.Name = "High";
            wheat1.PricePerKg = 40;
            wheat1.Weight = 50;

            Wheat wheat2 = new Wheat();
            wheat2.Name = "low";
            wheat2.PricePerKg = 25;
            wheat2.Weight = 40;

            Wheat wheat3 = new Wheat();
            wheat3.Name = "Medium";
            wheat3.PricePerKg = 60;
            wheat3.Weight = 20;

            InventoryTypes inventoryTypes2 = new InventoryTypes();
            inventoryTypes2.WheatList.Add(wheat1);
            inventoryTypes2.WheatList.Add(wheat2);
            inventoryTypes2.WheatList.Add(wheat3);


            Pulses pulse1 = new Pulses();
            pulse1.Name = "Green Gram";
            pulse1.PricePerKg = 20;
            pulse1.Weight = 60;

            Pulses pulse2 = new Pulses();
            pulse2.Name = "Black gram";
            pulse2.PricePerKg = 20;
            pulse2.Weight = 60;

            Pulses pulse3 = new Pulses();
            pulse3.Name = "Red gram";
            pulse3.PricePerKg = 20;
            pulse3.Weight = 60;

            InventoryTypes inventoryTypes3 = new InventoryTypes();
            inventoryTypes3.PulsesList.Add(pulse1);
            inventoryTypes3.PulsesList.Add(pulse2);
            inventoryTypes3.PulsesList.Add(pulse3);

            InventoryDetails inventoryDetails = new InventoryDetails();
            inventoryDetails.InventoryDetailsList.Add(inventoryTypes1);
            inventoryDetails.InventoryDetailsList.Add(inventoryTypes2);
            inventoryDetails.InventoryDetailsList.Add(inventoryTypes3);

            string jsonData = JsonConvert.SerializeObject(inventoryDetails);

            Console.WriteLine("Json string Created \n" + jsonData);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\temp.json",jsonData);
        }
    }  
}
