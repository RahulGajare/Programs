// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstView.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FirstView class
    /// </summary>
    public class FirstView
    {
        /// <summary>
        /// Starts the inventory manager.
        /// </summary>
       public static void StartInventoryManager()
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("Select an Inventory from Below");
                Console.WriteLine("0) To exit");
                Console.WriteLine("1) Rice");
                Console.WriteLine("2) Wheat");
                Console.WriteLine("3) Pulses");
                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                ////Calls the metods base on the Choosen option.
                switch (option)
                {
                    case 0:
                        {
                            return;                           
                        }

                    case 1:
                        {
                            InventoryMenuView.InventoryMenuview("RICE");
                            break;
                        }

                    case 2:
                        {
                            InventoryMenuView.InventoryMenuview("WHEAT");
                            break;
                        }

                    case 3:
                        {
                            InventoryMenuView.InventoryMenuview("PULSES");
                            break;
                        }
                }
            }
        }
    }
}
