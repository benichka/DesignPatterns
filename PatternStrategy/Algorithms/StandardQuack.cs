using System;
using PatternStrategy.Contracts;

namespace PatternStrategy.Algorithms
{
    /// <summary>
    /// This class defines a standard way to quack.
    /// </summary>
    public class StandardQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I quack like a standard duck.");
        }
    }
}
