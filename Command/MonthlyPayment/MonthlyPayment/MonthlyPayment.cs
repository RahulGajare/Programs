// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MonthlyPayment
{
    using System;

    /// <summary>
    /// Calculates Monthly payment
    /// </summary> 
    public class MonthlyPayment
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            double principle;
            double year;
            double rate;
            double payment;

            if (args.Length < 3 || args.Length > 3)
            {
                Console.WriteLine("Input correct Principle,Year and Rate");
                Console.Read();
                return;
            }

            try
            {
                principle = Convert.ToDouble(args[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Value for Principle");
                Console.Read();
                return;
            }

            if (args[1].Length > 4 || args[1].Length < 4)
            {
                Console.WriteLine("Invalid value for year");
                Console.Read();
                return;
            }

            try
            {
                year = Convert.ToDouble(args[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Value for year");
                Console.Read();
                return;
            }

            try
            {
                rate = Convert.ToDouble(args[2]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Value for rate");
                Console.Read();
                return;
            }

            payment = Utility.MonthlyPayment(principle, year, rate);

            Console.Write("payment = " + payment);
            Console.ReadLine();
        }
    }
}
