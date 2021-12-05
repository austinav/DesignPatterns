using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    public interface ISubject
    {
        public void registerObserver(IObserver observer);
        public void removeObserver(IObserver observer);
        public void notifyObservers();
    }
}
