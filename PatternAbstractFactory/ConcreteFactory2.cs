using System;

namespace PatternAbstractFactory
{
    /// <summary>
    /// Concrete factory 2.
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        /// <summary><inheritdoc/></summary>
        public override IProductA CreateProductA()
        {
            return new ConcreteProductA2() { SomePropertieA = "Property A of concrete product A2." };
        }

        /// <summary><inheritdoc/></summary>
        public override IProductB CreateProductB()
        {
            return new ConcreteProductB2() { SomePropertieB = "Property B of concrete product B2." };
        }
    }
}
