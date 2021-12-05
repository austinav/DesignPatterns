using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace ConsoleApp1.Patterns.Decorator
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal cost()
        {
            return this.beverage.cost() + .10m;
        }
    }
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal cost()
        {
            return this.beverage.cost() + .20m;
        }
    }
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override decimal cost()
        {
            return this.beverage.cost() + .15m;
        }
    }
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override decimal cost()
        {
            return this.beverage.cost() + .10m;
        }
    }
}