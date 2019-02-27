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
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory.json");
                InventoryDetails[] jsonObjectArray = JsonConvert.DeserializeObject<InventoryDetails[]>(jsonData);

                for (int i = 0; i < jsonObjectArray.Length; i++)
                {
                    Console.WriteLine("Name : " + jsonObjectArray[i].Name + "\nPrice Per Kg: " + jsonObjectArray[i].PricePerKg + "\n Weight: " + jsonObjectArray[i].Weight);
                    Console.WriteLine("Total price :" + jsonObjectArray[i].PricePerKg * jsonObjectArray[i].Weight);
                    Console.WriteLine("--------------------------------");


                }

            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                Console.Read();
            }
           
           

        }
    }
}
