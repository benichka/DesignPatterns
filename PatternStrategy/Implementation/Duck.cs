using PatternStrategy.Contracts;

namespace PatternStrategy.Implementation
{
    /// <summary>
    /// All that we ask for a duck is that it should quack and fly, in any way possible.
    /// </summary>
    public class Duck
    {
        // Dependency injection members.
        private readonly IQuack quack;
        private readonly IFly fly;

        /// <summary>
        /// Dependency injection constructor.
        /// </summary>
        /// <param name="quack">Defines how the duck is supposed to quack.</param>
        /// <param name="fly">Defines how the duck is supposed to fly.</param>
        public Duck(IQuack quack, IFly fly)
        {
            this.quack = quack;
            this.fly = fly;
        }

        /// <summary>
        /// Delegate the quack implementation to the DI.
        /// </summary>
        public void Quack()
        {
            quack.Quack();
        }

        /// <summary>
        /// Delegate the fly implementation to the DI.
        /// </summary>
        public void Fly()
        {
            fly.Fly();
        }
    }
}
