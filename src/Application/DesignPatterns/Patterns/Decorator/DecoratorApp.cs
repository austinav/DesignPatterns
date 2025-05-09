﻿using System;
using DesignPatterns;

namespace ConsoleApp1.Patterns.Decorator
{
    public class DecoratorApp : App
    {
        public override void MainProgram()
        {
            Beverage order = new Decaf();
            OutputOrder(order);

            order = new Whip(order);
            OutputOrder(order);

            order = new Mocha(order);
            OutputOrder(order);

            order = new Whip(order);
            OutputOrder(order);

            order = new SteamedMilk(order);
            OutputOrder(order);

            order.BeverageSize = Beverage.Size.GRANDE;
            OutputOrder(order);

            order.BeverageSize = Beverage.Size.VENTI;
            OutputOrder(order);
        }

        public void OutputOrder(Beverage order) => Console.WriteLine(order.Description + " costs " + order.cost());
    }
}
