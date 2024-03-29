﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ----------------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// replaces input(String) and replace it with template.
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the name.
        /// </summary>
        /// Calling this method will replace  input(String) and replace it with template.
        public static void ReplaceName()
        {
            try
            {
                bool keepLooping = true;

                while (keepLooping)
                {
                    Console.WriteLine("Enter your Name");
                    string name = Console.ReadLine();
                    if (name.Length < 3)
                    {
                        Console.WriteLine("Name length should be greater than 3");
                        continue;
                    }

                    if (Utility.CheckString(name))
                    {
                        Console.WriteLine("Hello <<" + name + ">>, How are you?");
                        keepLooping = false; //// program ended sucessfully
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
