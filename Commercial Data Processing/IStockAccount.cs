// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IStockAccount.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.Commercial_Data_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IStockAccount Interface
    /// </summary>
    interface IStockAccount
    {
        void Buy(long numberOfShares, double price, string symbol);
        void printReport();
    }
}
