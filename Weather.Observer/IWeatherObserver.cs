namespace Weather.Observer
{
    public interface IWeatherObserver
    {
        void Update(WeatherData data);
    }
}