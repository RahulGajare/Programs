using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    class NewsFeed
    {
        WeatherStation weatherStation;

        public void AddTemperatureInfoToFeed(int temperature)
        {
            Console.WriteLine("News Feed: New temperature " + temperature + " added to feed.");
        }

        public NewsFeed(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Reporter += AddTemperatureInfoToFeed;
        }
    }
}
