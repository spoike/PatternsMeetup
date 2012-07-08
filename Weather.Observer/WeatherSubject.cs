using System.Collections.Generic;

namespace Weather.Observer
{
    public abstract class WeatherSubject
    {
        private List<IWeatherObserver> observers = new List<IWeatherObserver>();

        public void RegisterObserver(IWeatherObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IWeatherObserver o)
        {
            if (observers.Contains(o))
                observers.Remove(o);
        }

        public void NotifyObservers(WeatherData data)
        {
            foreach (var weatherObserver in observers)
            {
                weatherObserver.Update(data);
            }
        }
    }
}