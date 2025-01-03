using System;
using System.Collections.Generic;

namespace WeatherApp
{
    class WeatherData: IObservable<Weather>
    {
        private List<IObserver<Weather>> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver<Weather>>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber<Weather>(_observers, observer);
        }

        public void Notify(Weather value)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(value);
            }
        }
    }
}
