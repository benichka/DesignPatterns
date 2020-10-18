using PatternObserver.Contracts;

namespace PatternObserver.Implementation
{
    public class CustomObserver : ICustomObserver
    {
        /// <summary>Observer state, depending on the implementation. Here, a simple string.</summary>
        public string State { get; private set; }

        /// <summary>
        /// Reference to the implementation of a specific observable, not an interface; that way,
        /// the Update method doesn't need a parameter containing updated data: the observer can simply
        /// get the interesting data directly from the observable object.
        /// </summary>
        private CustomObservable customObservable;

        /// <summary>
        /// The constructor needs the observable as a parameter.
        /// </summary>
        /// <param name="customObservable">Target observable.</param>
        public CustomObserver(CustomObservable customObservable)
        {
            this.customObservable = customObservable;
        }

        /// <summary>
        /// Update the state of the observer.
        /// Because there is a direct reference to the observable, no parameter is needed in
        /// that method.
        /// </summary>
        public void Update()
        {
            State = customObservable.GetState();
        }
    }
}
