using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Patterns.Decorator
{
    public class DecoratorApp : App
    {
        public override void Run()
        {
            Beverage order = new Decaf();
            Console.WriteLine(order.description + " costs " + order.cost());

            order = new Whip(order);
            Console.WriteLine(order.description + " costs " + order.cost());

            order = new Mocha(order);
            Console.WriteLine(order.description + " costs " + order.cost());

            order = new Whip(order);
            Console.WriteLine(order.description + " costs " + order.cost());

            order = new SteamedMilk(order);
            Console.WriteLine(order.description + " costs " + order.cost());
        }
    }
}
