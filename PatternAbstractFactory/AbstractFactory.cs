namespace PatternAbstractFactory
{
    /// <summary>
    /// Abstract factory in charge of providing product of the same family.
    /// Here, product "A" and product "B" are of the same family, hence this
    /// abstract factory will be responsible for providing the client with
    /// instances of it.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Provide a product A.
        /// </summary>
        /// <returns>A product A, instanciated with the correct needs regarding the factory.</returns>
        public abstract IProductA CreateProductA();
        /// <returns>A product B, instanciated with the correct needs regarding the factory.</returns>
        public abstract IProductB CreateProductB();
    }
}
