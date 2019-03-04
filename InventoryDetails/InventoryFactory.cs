// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryDetails
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;      
    using Newtonsoft.Json;

    /// <summary>
    /// InventoryFactory Class
    /// </summary>
    public class InventoryFactory
    {
        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <returns>returns Inventory details</returns>
        public static InventoryDetails ReadJsonFile()
        {
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Inventory.json"))
            {
                ////getting the JSon String From the File.
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory.json");

                ////Converting JsonString to Object;
                InventoryDetails jsonObjectArray = JsonConvert.DeserializeObject<InventoryDetails>(jsonData);

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new InventoryDetails();
            }       
        }
    }
}
