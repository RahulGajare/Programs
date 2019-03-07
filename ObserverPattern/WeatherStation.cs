using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    class WeatherStation
    {
        private int _temperature;
        public TemperatureReporter Reporter { get; set; }

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (Reporter != null)
                {
                    Reporter(value);
                }
                _temperature = value;
            }
        }
    }
}

