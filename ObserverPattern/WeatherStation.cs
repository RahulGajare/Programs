
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
    /// WeatherStation class
    /// </summary>
    public class WeatherStation
    {
        private int _temperature;
        public TemperatureReporter Reporter { get; set; }

        /// <summary>
        /// Temperature 
        /// </summary>
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

