using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace OOP.InventoryDetails
{
    class ReadJson
    {
        public static void ReadJsonFile()
        {
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Inventory.json"))
            {
                Console.WriteLine("is there");
                
            }
            string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory.json");
             InventoryDetails[] obj = JsonConvert.DeserializeObject<InventoryDetails[]>(jsonData);

            for (int i = 0; i < obj.Length;i++)
            {
                Console.WriteLine(obj[i].Name + " " + obj[i].PricePerKg + " " + obj[i].Weight);

               
            }
           

        }
    }
}
