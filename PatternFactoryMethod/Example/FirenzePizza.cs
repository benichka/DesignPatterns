using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod.Example
{
    public class FirenzePizza : IPizza
    {
        public IList<string> Toppings { get; set; }
        public string DoughType { get => "thin"; }

        public FirenzePizza(IList<string> ingredients)
        {
            Toppings = ingredients;
        }

        public void Bake()
        {
            Console.WriteLine("Baking Firenze pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Firenze pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Firenze pizza.");
        }
    }
}
