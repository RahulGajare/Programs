using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryManagementProgram
{
    class DataLogic
    {
        public static void WriteToFile(InventoryTypes inventoryType)
        {
            string jsonAdddressBook = JsonConvert.SerializeObject(inventoryType);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json", jsonAdddressBook);
        }
    }
}
