using System;
using PatternStrategy.Contracts;

namespace PatternStrategy.Algorithms
{
    /// <summary>
    /// This class defines how to quack when squeezed.
    /// </summary>
    public class SqueezeQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I quack like a rubber duck.");
        }
    }
}
