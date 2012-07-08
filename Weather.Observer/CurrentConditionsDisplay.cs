using System;

namespace Weather.Observer
{
    public class CurrentConditionsDisplay : ConsoleLogDisplay, IWeatherObserver
    {
        private readonly WeatherStation _station;
        private decimal _temperature;
        private decimal _humidity;

        public CurrentConditionsDisplay(WeatherStation station)
        {
            _station = station;
            station.RegisterObserver(this);
        }

        public void Update(WeatherData data)
        {
            _temperature = data.Temperature;
            _humidity = data.Humidity;
            Display();
        }

        public override string GetLogOutput()
        {
            return String.Format("Current conditions: {0:F1}F degrees and {1:F1}% humidity", _temperature, _humidity);
        }
    }
}