using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OOP.InventoryDetails
{
    class CreateObject
    {
        public static void CreateObjects()
        {
            InventoryDetails inventoryDetails = new InventoryDetails();
            inventoryDetails.Name = "Rice";
            inventoryDetails.Weight = 1000;
            inventoryDetails.PricePerKg = 60;

            InventoryDetails inventoryDetail = new InventoryDetails();
            inventoryDetail.Name = "Wheat";
            inventoryDetail.Weight = 2000;
            inventoryDetail.PricePerKg = 50;

            InventoryDetails[] goods = {inventoryDetail,inventoryDetails };

            string jsonData = JsonConvert.SerializeObject(goods);

            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\temp.json",jsonData);
        }
    }
}
