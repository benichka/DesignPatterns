using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod.Example
{
    public interface IPizza
    {
        IList<string> Toppings { get; set; }
        string DoughType { get; }
        void Bake();
        void Cut();
        void Box();
    }
}
