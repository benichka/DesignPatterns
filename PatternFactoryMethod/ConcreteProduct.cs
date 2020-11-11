using System;

namespace PatternFactoryMethod
{
    /// <summary>
    /// Implementation of IProduct: 1 type of
    /// a concrete product.
    /// </summary>
    class ConcreteProduct : IProduct
    {
        /// <summary><inheritdoc/></summary>
        public Guid Id { get; set; }
        /// <summary><inheritdoc/></summary>
        public string Colour { get; set; }
    }
}
