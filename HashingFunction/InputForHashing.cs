// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForHashing.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.HashingFunction
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// This class is for taking required inputs
    /// </summary>
    public class InputForHashing
    {
        /// <summary>
        /// Temporaries this instance.
        /// </summary>
        public static void StartHashing()
        {
            try
            {
                int numberToSearch = 0;
                ArrayList fileData = new ArrayList();
                string path = string.Empty;
                bool loopPath = true;
                while (loopPath)
                {
                    Console.WriteLine("Specify the path");
                    path = Console.ReadLine();

                    if (File.Exists(path) == false)
                    {
                        Console.WriteLine("Specified Path does not exist");
                        Console.Read();
                        continue;
                    }

                    loopPath = false;
                }

                string dataFromFile = System.IO.File.ReadAllText(path);
                string[] splitArray = dataFromFile.Split(" ");

                for (int i = 0; i < splitArray.Length; i++)
                {
                    if (splitArray[i].Trim() != string.Empty)
                    {
                        fileData.Add(Convert.ToInt32(splitArray[i]));
                    }
                }

                bool loopNumberToSearch = true;
                while (loopNumberToSearch)
                {
                    Console.WriteLine("Enter a number to search");
                    string stringNumberToSearch = Console.ReadLine();

                    if (Utility.IsNumber(stringNumberToSearch) == false)
                    {
                        Console.WriteLine("Invalid input, Enter a number to Seaerch");
                        continue;
                    }

                    numberToSearch = Convert.ToInt32(stringNumberToSearch);
                    loopNumberToSearch = false;
                }

                HashingFunction.Hashingfunction(fileData, numberToSearch, path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
    }
}
