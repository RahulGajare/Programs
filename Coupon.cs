// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Generates Distinct Coupons
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Generates the coupon.
        /// </summary>
        public static void GenerateCoupon()
        {
            try
            {
                int numberOfCoupons = 0;
                int[] couponArray = null;
                bool assignFlag = true; ////This will only allow to assign the value in array if its new.

                Random random = new Random(Guid.NewGuid().GetHashCode());

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter the Number of Coupons you want to generate");
                    string strNumberOfCoupons = Console.ReadLine();

                    if (Utility.IsNumber(strNumberOfCoupons) == false)
                    {
                        Console.WriteLine("Wrong Input, Enter only Integer");
                        continue;
                    }

                    numberOfCoupons = Convert.ToInt32(strNumberOfCoupons);
                    flag = false;
                }

                couponArray = new int[numberOfCoupons];

                int j = 0; //// index value for CouponArray
                while (numberOfCoupons != 0)
                {
                    int number = random.Next(100, 999);

                    foreach (int i in couponArray)
                    {
                        if (i == number)
                        {
                            flag = false;
                        }
                    }

                    if (assignFlag)
                    {
                        couponArray[j] = number;
                        j++;
                        numberOfCoupons--;
                    }
                }

                Console.WriteLine("The Generated Coupons are ");
                Utility.PrintArray(couponArray);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}
