using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Reggiano Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Fresh Clams Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");
            }
            else if (item.Equals("sause"))
            {
                pizza = new SausePizza(ingredientFactory);
                pizza.setName("New York Style Marinara Sauce Pizza");
            }
            else if (item.Equals("dough"))
            {
                pizza = new DoughPizza(ingredientFactory);
                pizza.setName("New York Style Thin Crust Dough Pizza");
            }
            return pizza;
        }
    }
}