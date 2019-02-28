using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryDetails
{
    class InventoryManager
    {
        public static void GetInventoryList()
        {
            InventoryDetails[] inventoryList = InventoryFactory.ReadJsonFile();
            for (int i = 0; i < inventoryList.Length; i++)
            {
                Console.WriteLine("Name : " + inventoryList[i].Name + "\nPrice Per Kg: " + inventoryList[i].PricePerKg + "\n Weight: " + inventoryList[i].Weight);
                Console.WriteLine("Total price :" + inventoryList[i].PricePerKg * inventoryList[i].Weight);
                Console.WriteLine("--------------------------------");

            }

            CreateObject.CreateObjects(inventoryList);
        }
    }
}
