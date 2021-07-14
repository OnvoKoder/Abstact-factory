using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public abstract class PizzaStore 
    {
        internal Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(string type);
    }
}
