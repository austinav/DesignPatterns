using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer.Displays
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private decimal maxTemp = 0.0m;
        private decimal minTemp = 200;
        private decimal tempSum = 0.0m;
        private int numReadings;

        public StatisticsDisplay(ISubject subject)
        {
            subject.registerObserver(this);
        }
        public void display() => Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings}/{maxTemp}/{minTemp} ");

        public void update(ISubject subject)
        {
            if (subject is WeatherData weatherData)
            {
                decimal temp = weatherData.Temperature;
                tempSum += temp;
                numReadings++;

                maxTemp = temp > maxTemp ? temp : maxTemp;

                minTemp = temp < minTemp ? temp : minTemp;

                display();
            }
        }
    }
}
