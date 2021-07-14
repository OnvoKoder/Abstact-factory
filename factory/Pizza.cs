using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public abstract class Pizza
    {
        protected String name;
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies [] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clam;

        protected List<string> toppings = new List<string>();

        public abstract void prepare();
        
        //    Console.WriteLine("Preparing" + name);
        //    Console.WriteLine("Tossing dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings: ");

        //    foreach (string topping in toppings)
        //    {
        //        Console.WriteLine(" " + topping);
        //    }
        

        public void bake ()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public string getName( )
        {
            return name;
        }
    }
}
