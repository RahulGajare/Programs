using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryManagementProgram
{
    class FirstView
    {
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
                string stringOption =Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

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
