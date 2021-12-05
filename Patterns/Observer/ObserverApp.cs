using System;
using System.Collections.Generic;
using System.Text;

using DesignPatterns;
using DesignPatterns.Patterns.Observer;
using DesignPatterns.Patterns.Observer.Displays;

namespace ConsoleApp1.Patterns.Observer
{
    class ObserverApp : App
    {
        public override void Run()
        {
            Console.WriteLine("Begin Weather Station");
            Console.WriteLine();

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4m);
            weatherData.setMeasurements(82, 70, 29.2m);
            weatherData.setMeasurements(78, 90, 29.2m);

        }
    }
}
