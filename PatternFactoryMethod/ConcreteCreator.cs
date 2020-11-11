using System;

namespace PatternFactoryMethod
{
    /// <summary>
    /// Concrete factory.
    /// In this implementation of the pattern, this
    /// factory automatically can execute AnOperation
    /// on IProduct.
    /// The specific implementation of FactoryMethod allow
    /// each factory to handle a different type of product.
    /// This factory handle ConcreteProduct, but another one
    /// can handle ConcreteProductB for instance.
    /// </summary>
    public class ConcreteCreator : Creator
    {
        /// <summary>
        /// This specific concrete factory handle IProduct
        /// of type ConcreteProduct.
        /// </summary>
        /// <returns>A ConcreteProduct.</returns>
        public override IProduct FactoryMethod()
        {
            // Implementation example.
            var product = new ConcreteProduct();
            product.Id = Guid.NewGuid();
            product.Colour = "yellow";

            return product;
        }
    }
}
