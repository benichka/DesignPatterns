namespace PatternAbstractFactory
{
    /// <summary>
    /// Represents a product "B", who is of the same family of product "A".
    /// </summary>
    public interface IProductB
    {
        /// <summary>Some property of this product.</summary>
        string SomePropertieB { get; set; }

        /// <summary>Another property of this product.</summary>
        string AnotherPropertieB { get; set; }
    }
}
