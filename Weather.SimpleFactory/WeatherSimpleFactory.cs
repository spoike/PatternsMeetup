using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weather.Observer;

namespace Weather.SimpleFactory
{
    public class WeatherSimpleFactory
    {
        private readonly WeatherStation _station;

        public WeatherSimpleFactory()
        {
            _station = new WeatherStation();
        }

        public WeatherStation WeatherStation
        {
            get { return _station; }
        }

        public ConsoleLogDisplay GetDisplay(Type type)
        {
            if (typeof(CurrentConditionsDisplay) == type)
            {
                return new CurrentConditionsDisplay(_station);
            }
            if (typeof(StatisticsDisplay) == type)
            {
                return new StatisticsDisplay(_station);
            }
            return null;
        }

    }
}
