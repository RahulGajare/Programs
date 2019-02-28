using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace OOP.InventoryDetails
{
    class InventoryFactory
    {
        public static InventoryDetails[] ReadJsonFile()
        {
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Inventory.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory.json");
                InventoryDetails[] jsonObjectArray = JsonConvert.DeserializeObject<InventoryDetails[]>(jsonData);

                return jsonObjectArray;

            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new InventoryDetails[0];
            }
           
           

        }
    }
}
