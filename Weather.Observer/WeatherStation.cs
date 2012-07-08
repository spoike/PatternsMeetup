namespace Weather.Observer
{
    public class WeatherStation : WeatherSubject
    {
        private decimal _pressure;
        private decimal _humidity;
        private decimal _temperature;

        public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers(new WeatherData {Temperature = _temperature, Humidity = _humidity, Pressure = _pressure});
        }
    }
}