using System;
using PatternStrategy.Contracts;

namespace PatternStrategy.Algorithms
{
    /// <summary>
    /// This class defines a method to... not fly!
    /// </summary>
    public class NoFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly :(.");
        }
    }
}
