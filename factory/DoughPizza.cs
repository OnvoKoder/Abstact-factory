using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class DoughPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public DoughPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
