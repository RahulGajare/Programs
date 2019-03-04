// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="DataLogic.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryManagementProgram
{   
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Data logic
    /// </summary>
    public class Datalogic
    {
        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="inventoryTypes">The inventory types.</param>
        public static void WriteToFile(InventoryTypes inventoryTypes)
        {
            ////Converting InventoryTypes Object to Json String
            string jsonAdddressBook = JsonConvert.SerializeObject(inventoryTypes);
            ////Wrinting Json String to file.
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json", jsonAdddressBook);
        }
    }
}
