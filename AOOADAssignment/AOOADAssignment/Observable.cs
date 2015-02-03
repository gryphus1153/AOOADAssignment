using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://msdn.microsoft.com/en-us/library/dd990377%28v=vs.110%29.aspx

namespace AOOADAssignment
{
    public class Observable
    {
        public Observable()
        {
            observers = new List<IObserver<Observable>>();
        }

        private List<IObserver<Observable>> observers;

        public IDisposable Subscribe(IObserver<Observable> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Observable>> _observers;
            private IObserver<Observable> _observer;

            public Unsubscriber(List<IObserver<Observable>> observers, IObserver<Observable> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
