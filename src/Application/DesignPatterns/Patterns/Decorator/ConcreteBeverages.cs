namespace ConsoleApp1.Patterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; } = "House Blend Coffee";

        public override decimal cost() => this.BeverageSize switch
        {
            Size.TALL => .89m,
            Size.GRANDE => .99m,
            Size.VENTI => 1.09m,
            _ => .89m
        };
    }

    public class DarkRoast : Beverage
    {
        public override string Description { get; } = "Dark Roast Coffee";

        public override decimal cost() => this.BeverageSize switch
        {
            Size.TALL => .99m,
            Size.GRANDE => 1.09m,
            Size.VENTI => 1.19m,
            _ => .99m,
        };
    }

    public class Espresso : Beverage
    {
        public override string Description { get; } = "Espresso";

        public override decimal cost() => this.BeverageSize switch
        {
            Size.TALL => 1.99m,
            Size.GRANDE => 2.19m,
            Size.VENTI => 2.39m,
            _ => 1.99m,
        };
    }

    public class Decaf : Beverage
    {
        public override string Description { get; } = "Decaf Coffee";

        public override decimal cost() => this.BeverageSize switch
        {
            Size.TALL => 1.05m,
            Size.GRANDE => 1.19m,
            Size.VENTI => 1.39m,
            _ => 1.05m,
        };
    }
}
