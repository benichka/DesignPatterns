﻿using System.Collections.Generic;

namespace PatternFactoryMethod.Example
{
    public abstract class AbstractPizzaStore
    {
        public IPizza OrderPizza(IList<string> toppings)
        {
            IPizza pizza = CreatePizza(toppings);

            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract IPizza CreatePizza(IList<string> toppings);
    }
}
