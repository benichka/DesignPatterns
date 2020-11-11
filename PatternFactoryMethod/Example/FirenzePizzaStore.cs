using System.Collections.Generic;

namespace PatternFactoryMethod.Example
{
    public class FirenzePizzaStore : AbstractPizzaStore
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new FirenzePizza(toppings);
        }
    }
}
