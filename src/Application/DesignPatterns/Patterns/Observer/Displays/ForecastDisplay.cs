using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer.Displays
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private decimal currentPressure = 29.92m;
        private decimal lastPressure;

        public ForecastDisplay(ISubject subject)
        {
            subject.registerObserver(this);
        }

        public void display() 
        {
            Console.Write($"Forecast: "); 
		    if (currentPressure > lastPressure) 
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else if (currentPressure < lastPressure)
                Console.WriteLine("Watch out for cooler, rainy weather");
        }

        public void update(ISubject subject)
        {
            if(subject is WeatherData weatherData)
            {
                this.lastPressure = this.currentPressure;
                this.currentPressure = weatherData.Pressure;
                display();
            }
            
        }
    }
}
