namespace PatternAbstractFactory
{
    /// <summary>
    /// A concrete implementation of IProductA.
    /// </summary>
    public class ConcreteProductA1 : IProductA
    {
        /// <summary><inheritdoc/></summary>
        public string SomePropertieA { get; set; }
        /// <summary><inheritdoc/></summary>
        public string AnotherPropertieA { get; set; }
    }
}
