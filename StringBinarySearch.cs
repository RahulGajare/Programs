

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StringBinarySearch
    {
        public static void Main()
        {
             Console.Write("Enter the Path of file you want to search a Name from.");
            Console.WriteLine();
            
             string filePath = Console.ReadLine();
            Console.WriteLine("Enter the string you want to search");
            string toSearch = Console.ReadLine();

             string fileContent = System.IO.File.ReadAllText(filePath);

            string[] namesArray = fileContent.Split(',');

            if (Utility.BinarySearchString(namesArray, toSearch))
            {
                Console.WriteLine("found " + toSearch);
            }
            else
            {
                Console.WriteLine("Not found ");
            }

            Console.Read();
        }
    }
}
