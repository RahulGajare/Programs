

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StringBinarySearch
    {
        public static void BinarySearchString()
        {
            string filePath = "";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter the Path of file you want to search a Name from.");


                filePath = Console.ReadLine();
                if (File.Exists(filePath) == false)
                {
                    Console.WriteLine("Specified file does not exist, try again");
                    continue;
                }

                loop = false;
            }
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
