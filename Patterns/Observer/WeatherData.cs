using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        public decimal Temperature { get; private set; }
        public decimal Humidity { get; private set; }
        public decimal Pressure { get; private set; }

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void notifyObservers() => observers.ForEach(o => o.update(this));
        public void registerObserver(IObserver observer) => observers.Add(observer);
        public void removeObserver(IObserver observer) => observers.Remove(observer);

        public void measurementsChanged() => notifyObservers();

        public void setMeasurements(decimal temperature, decimal humidity, decimal pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            measurementsChanged();
        }
    }
}
