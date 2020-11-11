namespace PatternAbstractFactory
{
    /// <summary>
    /// Represents a product "A", who is of the same family of product "B".
    /// </summary>
    public interface IProductA
    {
        /// <summary>Some property of this product.</summary>
        string SomePropertieA { get; set; }

        /// <summary>Another property of this product.</summary>
        string AnotherPropertieA { get; set; }
    }
}
