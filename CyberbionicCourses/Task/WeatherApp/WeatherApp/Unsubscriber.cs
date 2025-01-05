using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace WeatherApp
{
    internal class Unsubscriber<TypeDefinition> : IDisposable
    {
        private List<IObserver<TypeDefinition>> _observers;
        private IObserver<TypeDefinition> _observer;

        public Unsubscriber(List<IObserver<TypeDefinition>> observers, IObserver<TypeDefinition> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}