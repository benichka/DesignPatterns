using System.Collections.Generic;

namespace PatternFactoryMethod.Example
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new ChicagoPizza(toppings);
        }
    }
}
