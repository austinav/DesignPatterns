using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp1.Patterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public override string description { get; } = "House Blend Coffee";

        public override decimal cost()
        {
            return 0.89m;
        }
    }

    public class DarkRoast : Beverage
    {
        public override string description { get; } = "Dark Roast Coffee";

        public override decimal cost()
        {
            return 0.99m;
        }
    }

    public class Espresso : Beverage
    {
        public override string description { get; } = "Espresso";

        public override decimal cost()
        {
            return 1.99m;
        }
    }
    public class Decaf : Beverage
    {
        public override string description { get; } = "Decaf Coffee";

        public override decimal cost()
        {
            return 1.05m;
        }
    }
}