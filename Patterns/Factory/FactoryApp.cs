using System;
using System.Collections.Generic;
using System.Text;

using DesignPatterns;
using DesignPatterns.Patterns.Factory;

namespace ConsoleApp1.Patterns.Factory
{
    class FactoryApp : App
    {
        public override void Run() 
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            var pizza = nyPizzaStore.orderPizza("cheese");

            Console.WriteLine();

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            pizza = chicagoPizzaStore.orderPizza("clam");

            Console.WriteLine();

            pizza = nyPizzaStore.orderPizza("pepperoni");

            Console.WriteLine();
        }
    }
}
