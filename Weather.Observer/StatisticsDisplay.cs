using System;
using System.Collections.Generic;
using System.Linq;

namespace Weather.Observer
{
    public class StatisticsDisplay : ConsoleLogDisplay, IWeatherObserver
    {
        private WeatherStation _station;
        private readonly List<decimal> _temperatures = new List<decimal>();
        private decimal _min = decimal.MaxValue;
        private decimal _max = decimal.MinValue;

        public StatisticsDisplay(WeatherStation station)
        {
            _station = station;
            station.RegisterObserver(this);
        }

        public override string GetLogOutput()
        {
            var avg = _temperatures.Average();
            return String.Format("Avg/Max/Min temperature = {0:F1}/{1:F1}/{2:F1}", avg, _max, _min);
        }

        public void Update(WeatherData data)
        {
            decimal current = data.Temperature;
            _temperatures.Add(current);
            if (current < _min) _min = current;
            if (current > _max) _max = current;
            Display();
        }
    }
}