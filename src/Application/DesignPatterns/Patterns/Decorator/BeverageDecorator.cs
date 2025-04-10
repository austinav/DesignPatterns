namespace ConsoleApp1.Patterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public override Size BeverageSize
        {
            get => beverage.BeverageSize;
            set => beverage.BeverageSize = value;
        }

        public override string Description => 
            this.beverage.GetType().BaseType == (typeof(Beverage))
                ? $"{this.beverage.Description} with {this.GetType().Name}"
                : $"{this.beverage.Description} and {this.GetType().Name}";
    }
}
