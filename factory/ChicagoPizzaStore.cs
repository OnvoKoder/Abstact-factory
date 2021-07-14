using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoPizzaStore: PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizza_IngredientFactory();
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Mozzarella Cheese Pizza");
            }
            else if (item.Equals("sause"))
            {
                pizza = new SausePizza(ingredientFactory);
                pizza.setName("Chicago  Style Plum Tomato Sauce Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Frozen Clams Pizza");
            }
            else if (item.Equals("dough"))
            {
                pizza = new DoughPizza(ingredientFactory);
                pizza.setName("Chicago Style Thick Crust Dough Pizza");
            }
            return pizza;
        }
    }
}
