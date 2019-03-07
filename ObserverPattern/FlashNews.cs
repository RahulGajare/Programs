using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    class FlashNews
    {
        WeatherStation weatherStation;

        public void ShowTemperatureInfoInFlashNews(int temperature)
        {
            Console.WriteLine("Flash News: New temperature is " + temperature + ".");
        }

        public FlashNews(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
            weatherStation.Reporter += ShowTemperatureInfoInFlashNews;
        }
    }
}
