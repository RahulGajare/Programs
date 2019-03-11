
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
    public delegate void TemperatureReporter(int tempearture);
    /// <summary>
    /// StartObserver class
    /// </summary>
    public class StartObserver
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Startobserver()
        {
            //// Observer Pattern Using Delegates
            WeatherStation weatherStation = new WeatherStation();
            FlashNews flashNews = new FlashNews(weatherStation);
            NewsFeed newsFeed = new NewsFeed(weatherStation);
            weatherStation.Temperature = 30;
            weatherStation.Temperature = 15;
            weatherStation.Temperature = 45;
            Console.Read();
        }
    }
}
