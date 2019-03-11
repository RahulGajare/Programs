
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
    /// NewsFeed class
    /// </summary>
    public class NewsFeed
    {
        WeatherStation weatherStation;

        /// <summary>
        /// Adds the temperature information to feed.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        public void AddTemperatureInfoToFeed(int temperature)
        {
            Console.WriteLine("News Feed: New temperature " + temperature + " added to feed.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsFeed"/> class.
        /// </summary>
        /// <param name="weatherStation">The weather station.</param>
        public NewsFeed(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Reporter += AddTemperatureInfoToFeed;
        }
    }
}
