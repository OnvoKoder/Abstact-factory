using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();
        }
    }
}
