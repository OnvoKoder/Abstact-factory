using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough createDough()
        {
            return new ThinCrustDough();
        }
        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }
        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }
        public IVeggies[] createVeggies()
        {
            IVeggies [] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public IClams createClam()
        {
            return new FreshClams();
        }
        public IOlives createOlives()
        {
            return new BlackOlives();
        }
        public ISpinach createSpainach()
        {
            return new Spinach();
        }
        public IEgg createEgg()
        {
            return new EggPlant();
        }
    }
}
