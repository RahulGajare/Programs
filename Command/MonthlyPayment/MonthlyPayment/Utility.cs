// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace MonthlyPayment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility methods
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Monthlies the payment.
        /// </summary>
        /// <param name="principle">The principle.</param>
        /// <param name="year">The year.</param>
        /// <param name="rate">The rate.</param>
        /// <returns> returns payment</returns>
        public static double MonthlyPayment(double principle, double year, double rate)
        {
            double n = 12 * year;
            rate = rate / (12 * 100);
            double power = Math.Pow(1 + rate, -n);
            double payment = principle * rate / (1 - power);
            return payment;
        }
    }
}
