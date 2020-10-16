using System;

namespace PatternAdapter.BadImplementation
{
    public class BadRubberDuck : BadDuck
    {
        public override void Fly()
        {
            Console.WriteLine("I cannot fly :(.");
        }

        public override void Quack()
        {
            Console.WriteLine("I quack like a rubber duck.");
        }
    }
}
