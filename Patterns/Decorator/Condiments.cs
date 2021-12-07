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
            decimal myCost = 0;
            switch (this.beverage.BeverageSize)
            {
                case Size.TALL:
                    myCost = .20m;
                    break;
                case Size.GRANDE:
                    myCost = .30m;
                    break;
                case Size.VENTI:
                    myCost = .40m;
                    break;
                default:
                    myCost = .20m;
                    break;
            }

            return this.beverage.cost() + myCost;
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