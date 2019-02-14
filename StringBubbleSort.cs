using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class StringBubbleSort
    {
        public static void Stringbubblesort()
        {
            string[] userArray=Utility.TakeInputStringArray();

            Utility.PrintArrayString(Utility.BubbleSortString(userArray));
            Console.Read();

        }
    }
}
