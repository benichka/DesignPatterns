using System;
using System.Collections.Generic;

namespace PatternFactoryMethod.Example
{
    public class ChicagoPizza : IPizza
    {
        public IList<string> Toppings { get; set; }
        public string DoughType { get => "pan"; }

        public ChicagoPizza(IList<string> ingredients)
        {
            Toppings = ingredients;
        }

        public void Bake()
        {
            Console.WriteLine("Baking New York pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing New York pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting New York pizza.");
        }
    }
}
