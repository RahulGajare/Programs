
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FlashNews class
    /// </summary>
    public class FlashNews
    {
        WeatherStation weatherStation;

        /// <summary>
        /// Shows the temperature information in flash news.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        public void ShowTemperatureInfoInFlashNews(int temperature)
        {
            Console.WriteLine("Flash News: New temperature is " + temperature + ".");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlashNews"/> class.
        /// </summary>
        /// <param name="weatherStation">The weather station.</param>
        public FlashNews(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Reporter += ShowTemperatureInfoInFlashNews;
        }
    }
}
