// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForHashing.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace DataStructures.HashingFunction
{
    using System;
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
        public static void Temp()
        {
            int[] hashArray = new int[10];
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
                    hashArray[i] = Convert.ToInt32(splitArray[i]);
                }
            }
        }
    }
}
