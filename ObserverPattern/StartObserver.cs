using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    public delegate void TemperatureReporter(int tempearture);
    class StartObserver
    {
       
        static void Main(string[] args)
        {
            // Observer Pattern Using Delegates
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
