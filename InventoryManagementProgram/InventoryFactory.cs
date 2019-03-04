// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryManagementProgram
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
        public static InventoryTypes ReadJsonFile()
        {
            ////checks Wheather File Exist or Not.
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json");

                ////Getting the inventoryTypes Object from the  JSon String.
                InventoryTypes jsonObjectArray = JsonConvert.DeserializeObject<InventoryTypes>(jsonData);

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new InventoryTypes();
            }       
        }
    }
}
