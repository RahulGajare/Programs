using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PrimeAnagrams
{
    class _2DPrimeAnagrams
    {
        public static void Print2DPrimeAnagram()
        {
            string [,] array =Utility.GetAnagrams(Utility.GetPrimeNumbersList());

            Utility.PrintMatrix(array);
        }
    }
}
