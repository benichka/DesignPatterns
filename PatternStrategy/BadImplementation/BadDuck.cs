using System;

namespace PatternAdapter.BadImplementation
{
    /// <summary>
    /// This class represents a duck; all 'sub-ducks' will inherit from it.
    /// </summary>
    public class BadDuck
    {
        /// <summary>
        /// A duck should quack.
        /// </summary>
        public virtual void Quack()
        {
            Console.WriteLine("Quack quack!");
        }

        /// <summary>
        /// A duck should be able to fly.
        /// </summary>
        public virtual void Fly()
        {
            Console.WriteLine("Flap flap flap!");
        }
    }
}
