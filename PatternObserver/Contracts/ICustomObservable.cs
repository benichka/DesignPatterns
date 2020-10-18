using System.Collections.Generic;

namespace PatternObserver.Contracts
{
    /// <summary>
    /// Define a custom type that will be observable.
    /// </summary>
    public interface ICustomObservable
    {
        // We need to maintain a list of observers and notify them of update.
        // The notification process (trigger, state, etc.) is handled in the
        // observable implementation.
        List<ICustomObserver> Observers { get; set; }
        void Register(ICustomObserver observer);
        void Unregister(ICustomObserver observer);
        void Notify();
    }
}
