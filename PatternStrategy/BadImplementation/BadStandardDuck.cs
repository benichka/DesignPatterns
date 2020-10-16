using System;

namespace PatternAdapter.BadImplementation
{
    /// <summary>
    /// This class represents a standard duck (mallard, mandarin duck...).
    /// </summary>
    public class BadStandardDuck : BadDuck
    {
        public override void Fly()
        {
            Console.WriteLine("I fly like a standard duck.");
        }

        public override void Quack()
        {
            Console.WriteLine("I quack like a standard duck.");
        }
    }
}
