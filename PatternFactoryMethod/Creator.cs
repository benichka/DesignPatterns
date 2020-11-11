namespace PatternFactoryMethod
{
    /// <summary>
    /// Abstract factory: every factory will inherit
    /// from it.
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// Factory method: this method will return some IProduct
        /// based on a specific concrete factory.
        /// This is the factory method described by the pattern!
        /// Responsibility of creating a specific product will be given
        /// to subclasses of Creator.
        /// </summary>
        /// <returns>An IProduct.</returns>
        public abstract IProduct FactoryMethod();

        /// <summary>
        /// AnOperation can be every operation that factories
        /// will have in common: probably some kind of a common
        /// treatment for IProduct.
        /// </summary>
        public void AnOperation()
        {
            // Eventually, do stuff before.
            IProduct product = FactoryMethod();
            // do stuff with the product:
            // product.Operation1();
            // product.Operation2();
            // etc.
        }
    }
}
