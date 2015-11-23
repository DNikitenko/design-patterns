using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    /// <summary>
    /// A typical metal fan to receive notifications
    /// </summary>
    class MetalFan : IObserver<MetalEvent>
    {
        /// <summary>
        /// IDisposable object to free resources after subscription is over
        /// </summary>
        private IDisposable _unsubscriber { get; set; }

        private string _name { get; set; }

        public MetalFan(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Turn on notification receiving from specified publisher
        /// </summary>
        /// <param name="publisher"></param>
        public void Subscribe(IObservable<MetalEvent> publisher)
        {
            if (publisher != null)
            {
                _unsubscriber = publisher.Subscribe(this);
            }
        }

        /// <summary>
        /// Unsubscribe from current publisher
        /// </summary>
        public void Unsubscribe()
        {
            Console.WriteLine("{0} is unsubscribing...", _name);

            if (_unsubscriber != null)
            {
                _unsubscriber.Dispose();
            }
        }

        /// <summary>
        /// Say something when subscription is over
        /// </summary>
        public void OnCompleted()
        {
            Console.WriteLine("No more metal... ({0} is being told that publisher has closed subscription)", _name);
            Unsubscribe();
        }

        /// <summary>
        /// Unexpectable stuff detected
        /// </summary>
        /// <param name="error"></param>
        public void OnError(Exception error)
        {
            Console.WriteLine("Something's gone wrong, reports {0}: {1}", _name, error.Message);
        }

        /// <summary>
        /// A fan receive notification about one more metal event
        /// </summary>
        /// <param name="value"></param>
        public void OnNext(MetalEvent value)
        {
            Console.WriteLine("{0} is going to visit {1} at {2}", _name, value.Band, value.Date);
        }
    }
}
