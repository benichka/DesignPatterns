using System;

namespace PatternFactoryMethod
{
    /// <summary>
    /// IProduct is the interface representing a product
    /// that will be handled by factories.
    /// </summary>
    public interface IProduct
    {
        /// <summary>Some product id.</summary>
        Guid Id { get; set; }

        /// <summary>A specific colour for the product.</summary>
        string Colour { get; set; }
    }
}
