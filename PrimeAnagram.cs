

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PrimeAnagram
    {
        public static void PrintPrimeAnagram()
        {
            Utility.PrintAnagrams(Utility.GetPrimeNumbersList());
            Console.Read();
        }
    }
}
