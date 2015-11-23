using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    /// <summary>
    /// Some event aggregator that knows everything about forthcoming metal concerts
    /// </summary>
    class MetalEventNewsmaker : IObservable<MetalEvent>
    {
        /// <summary>
        /// Who the fuck are you to unsubscribe that?
        /// But IObservable interface requires IDisposable object, so we hide it inside to nobody see that shame
        /// </summary>
        private class MetalEventUnsubscriber : IDisposable
        {
            private List<IObserver<MetalEvent>> _subscribers;
            private IObserver<MetalEvent> _subscriber;

            public MetalEventUnsubscriber(List<IObserver<MetalEvent>> observers, IObserver<MetalEvent> observer)
            {
                this._subscribers = observers;
                this._subscriber = observer;
            }

            /// <summary>
            /// Unsubscribe from metal event notifications. What a nonsense
            /// </summary>
            public void Dispose()
            {
                if (_subscriber != null && _subscribers.Contains(_subscriber))
                    _subscribers.Remove(_subscriber);
            }
        }

        /// <summary>
        /// List of metal fans to get notifications
        /// </summary>
        private readonly List<IObserver<MetalEvent>> _subscribers = new List<IObserver<MetalEvent>>();

        /// <summary>
        /// After subscribe observer will receive notifications about events
        /// </summary>
        /// <param name="subscriber"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<MetalEvent> subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }

            return new MetalEventUnsubscriber(_subscribers, subscriber);
        }

        /// <summary>
        /// Perform broadcasting about new metal event
        /// </summary>
        /// <param name="newEvent"></param>
        public void TellAboutEvent(MetalEvent newEvent)
        {
            foreach (var subscriber in _subscribers)
            {
                if (newEvent == null)
                {
                    subscriber.OnError(new ArgumentNullException("Burn in hell! You're trying to fool me"));
                }

                subscriber.OnNext(newEvent);
            }
        }

        /// <summary>
        /// Close this fucking publisher
        /// </summary>
        public void StopBroadcasting()
        {
            //Create a copy of collection because subscriber are going to remove theirserves from collection while disposing
            foreach (var subscriber in _subscribers.ToArray())
            {
                subscriber.OnCompleted();
            }

            _subscribers.Clear();
        }
    }
}
