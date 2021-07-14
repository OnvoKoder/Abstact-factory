using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public interface PizzaIngredientFactory
    {
        public IDough createDough();
        public ISauce createSauce();
        public ICheese createCheese();
        public IVeggies[] createVeggies();
        public IPepperoni createPepperoni();
        public IClams createClam();
        public IEgg createEgg();
        public IOlives createOlives();
        public ISpinach createSpainach();

    }
}
