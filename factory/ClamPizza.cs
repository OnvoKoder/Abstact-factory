using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public ClamPizza(PizzaIngredientFactory ingredientFactory) 
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
