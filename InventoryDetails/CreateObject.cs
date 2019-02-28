using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OOP.InventoryDetails
{
    class CreateObject
    {
        public static void CreateObjects(InventoryDetails[] inventoryObjects)
        {
            string jsonData = JsonConvert.SerializeObject(inventoryObjects);

            Console.WriteLine("Json string Created \n" + jsonData);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\temp.json",jsonData);
        }
    }
}
