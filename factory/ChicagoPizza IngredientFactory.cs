using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoPizza_IngredientFactory : PizzaIngredientFactory
    {
        public IOlives createOlives()
        {
            return new BlackOlives();
        }
        public ISpinach createSpainach()
        {
            return new Spinach();
        }
        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public IEgg createEgg()
        {
            return new EggPlant();
        }
        public IDough createDough()
        {
            return new ThickCrustDoug();
        }
        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }
        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }
        public IClams createClam()
        {
            return new rozenClams();
        }
        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
