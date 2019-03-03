using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryManagementProgram
{
    class InputsForInventory
    {
        public static void TakeInputs(string inventoryType)
        {
            string name = null;

            double weight = 0;
            double pricePerKG = 0;

            while (true)
            {
                Console.WriteLine("Enter the Name for " + inventoryType);
                name = Console.ReadLine();

                if (Utility.ContainsCharacter(name))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(name))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(name))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Weight");
               string stringWeight =  Console.ReadLine();

                try
                {
                    weight = Convert.ToDouble(stringWeight);
                    break;
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid Input For Weight");
                    continue;
                }
            }

            while (true)
            {
                Console.WriteLine("Specify Price per Kg");
                string stringPrice = Console.ReadLine();
                try
                {
                    pricePerKG = Convert.ToDouble(stringPrice);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input For Price Per KG");
                    continue;
                }
            }
           
        }
    }

}
