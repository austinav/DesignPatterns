using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Patterns.Observer.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private decimal temperature;
        private decimal humidity;

        public CurrentConditionsDisplay(ISubject subject)
        {
            subject.registerObserver(this);
        }
        public void display() => Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        public void update(ISubject subject)
{
            if (subject is WeatherData weatherData)
            {
                this.temperature = weatherData.Temperature;
                this.humidity = weatherData.Humidity;
                display();
            }
            
        }
    }
}
