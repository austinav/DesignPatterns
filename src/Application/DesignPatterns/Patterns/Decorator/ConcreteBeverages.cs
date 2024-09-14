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
            switch(this.BeverageSize)
            {
                case Size.TALL:
                    return .89m;
                case Size.GRANDE:
                    return .99m;
                case Size.VENTI:
                    return 1.09m;
                default:
                    return .89m;
            }
        }
    }

    public class DarkRoast : Beverage
    {
        public override string description { get; } = "Dark Roast Coffee";

        public override decimal cost()
        {
            switch (this.BeverageSize)
            {
                case Size.TALL:
                    return .99m;
                case Size.GRANDE:
                    return 1.09m;
                case Size.VENTI:
                    return 1.19m;
                default:
                    return .99m;
            }
        }
    }

    public class Espresso : Beverage
    {
        public override string description { get; } = "Espresso";

        public override decimal cost()
        {
            switch (this.BeverageSize)
            {
                case Size.TALL:
                    return 1.99m;
                case Size.GRANDE:
                    return 2.19m;
                case Size.VENTI:
                    return 2.39m;
                default:
                    return 1.99m;
            }
        }
    }
    public class Decaf : Beverage
    {
        public override string description { get; } = "Decaf Coffee";

        public override decimal cost()
        {
            switch (this.BeverageSize)
            {
                case Size.TALL:
                    return 1.05m;
                case Size.GRANDE:
                    return 1.19m;
                case Size.VENTI:
                    return 1.39m;
                default:
                    return 1.05m;
            }
        }
    }
}