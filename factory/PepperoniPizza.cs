using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
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
