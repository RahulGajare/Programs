using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryManagementProgram
{
    class InventoryMenuView
    {
        public static void InventoryMenuview(string inventoryType)
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Choose an Option");
                Console.WriteLine("0) To Go Back");
                Console.WriteLine("1) To view Existing Inventory for " + inventoryType);
                Console.WriteLine("2) To Remove an " + inventoryType +" Item");
                Console.WriteLine("3) To Add " + inventoryType + " Item");
                Console.WriteLine("4) To Edit from Existing "+ inventoryType + " Inventory");

                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
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
                            InventoryManager.GetInventoryList(inventoryType);
                            break;
                        }

                    case 2:
                        {

                            break;
                        }

                    case 3:
                        {

                            break;
                        }

                    case 4:
                        {
                            break;
                        }
                }
            }
           
        }
    }
}
