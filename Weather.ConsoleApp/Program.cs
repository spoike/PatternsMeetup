using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weather.Observer;

namespace Weather.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(station);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(station);

            station.SetMeasurements(80, 65, new decimal(30.4));
            station.SetMeasurements(82, 70, new decimal(29.2));
            station.SetMeasurements(78, 90, new decimal(29.2));

            Console.ReadKey();
        }
    }
}
