// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringBinarySearch.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Searches a String using binary Method
    /// </summary>
    public class StringBinarySearch
    {
        /// <summary>
        /// Binaries the search string.
        /// </summary>
        public static void BinarySearchString()
        {
            try
            {
                string filePath = string.Empty;
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
