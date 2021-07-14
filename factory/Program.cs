using System;

namespace Laba15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.orderPizza("cheese");
        }
    }
}
