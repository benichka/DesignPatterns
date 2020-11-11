namespace PatternAbstractFactory
{
    /// <summary>
    /// Concrete factory 1.
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <summary><inheritdoc/></summary>
        public override IProductA CreateProductA()
        {
            return new ConcreteProductA1() { SomePropertieA = "Property A of concrete product A1." };
        }

        /// <summary><inheritdoc/></summary>
        public override IProductB CreateProductB()
        {
            return new ConcreteProductB1() { SomePropertieB = "Property B of concrete product B1." };
        }
    }
}
