using System.Collections.Generic;
using PatternObserver.Contracts;

namespace PatternObserver.Implementation
{
    public class CustomObservable : ICustomObservable
    {
        /// <summary>Observable state. Here, a simple string for this implementation.</summary>
        private string state;

        public List<ICustomObserver> Observers { get; set; }

        /// <summary>
        /// In this constructor, we simply instanciate the list of observers.
        /// </summary>
        public CustomObservable()
        {
            Observers = new List<ICustomObserver>();
        }

        public void Register(ICustomObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unregister(ICustomObserver observer)
        {
            Observers.Remove(observer);
        }

        /// <summary>
        /// Notify each observer that something's changed.
        /// </summary>
        public void Notify()
        {
            Observers.ForEach(observer => observer.Update());
        }

        /// <summary>
        /// When notified, the observers can call this method to get the
        /// observable state. Not in the interface because this method
        /// can be class-specific.
        /// </summary>
        /// <returns>The state of the observable.</returns>
        public string GetState()
        {
            return state ?? string.Empty;
        }

        /// <summary>
        /// When the state is updated, the Notify method is call so that
        /// every subscriber can be updated on that change.
        /// Again, this method is only on the implementation because it
        /// is class-specific.
        /// </summary>
        /// <param name="state">The new state for the observable.</param>
        /// <returns></returns>
        public void SetState(string state)
        {
            this.state = state;
            Notify();
        }
    }
}
