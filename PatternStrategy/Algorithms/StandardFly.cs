using System;
using PatternStrategy.Contracts;

namespace PatternStrategy.Algorithms
{
    /// <summary>
    /// This class defines a standard way to fly.
    /// </summary>
    public class StandardFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly like a standard duck.");
        }
    }
}
