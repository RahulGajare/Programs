using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntBubbleSort
    {
        public static void BubbleSortInt()
        {
            int[] userArray=Utility.TakeInputIntArray();
            Console.WriteLine("Bubble Sorted");
            Utility.PrintArrayInt(Utility.BubbleSortInt(userArray));
            Console.Read();
        }
    }
}
