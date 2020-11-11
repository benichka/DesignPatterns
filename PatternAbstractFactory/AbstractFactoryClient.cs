using System;

namespace PatternAbstractFactory
{
    /// <summary>
    /// Client class for the abstract factory.
    /// </summary>
    public class AbstractFactoryClient
    {
        public void Main()
        {
            Console.WriteLine("Testing abstract factory with concrete factory 1:");
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("Testing abstract factory with concrete factory 2:");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(AbstractFactory abstractFactory)
        {
            IProductA productA = abstractFactory.CreateProductA();
            IProductB productB = abstractFactory.CreateProductB();

            Console.WriteLine($"Product 1: {productA.SomePropertieA}");
            Console.WriteLine($"Product 2: {productB.SomePropertieB}");
        }
    }
}
