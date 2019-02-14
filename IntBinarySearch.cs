using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntBinarySearch
    {
        public static void BinarySearchInt()
        {
            int [] userArray = Utility.TakeInputIntArray();
            int numberToSearch = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the int you want to search");
                string strInt = Console.ReadLine();
                if (Utility.IsNumber(strInt) == false)
                {
                    Console.WriteLine("You can only search for an Int");
                }

                numberToSearch = Convert.ToInt32(strInt);
                    flag = false ;
            }


            if (Utility.BinarySearchInteger(userArray, numberToSearch) == false)
            {
                Console.WriteLine("Does not contain int " + numberToSearch);
            }
            else
            {
                Console.WriteLine("found ");
            }
            Console.Read();
        }
    }
}
