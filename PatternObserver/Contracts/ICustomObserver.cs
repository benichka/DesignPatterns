namespace PatternObserver.Contracts
{
    /// <summary>
    /// Define a custom type that will be able to observe an observer.
    /// </summary>
    public interface ICustomObserver
    {
        // Only 1 method is needed: update the observer when the observable change.
        void Update();
    }
}
