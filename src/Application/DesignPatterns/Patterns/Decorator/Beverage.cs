namespace ConsoleApp1.Patterns.Decorator
{
    public abstract class Beverage
    {
        public enum Size
        {
            TALL,
            GRANDE,
            VENTI,
        };

        private Size beverageSize;
        public virtual Size BeverageSize
        {
            get => beverageSize;
            set => beverageSize = value;
        }

        public Beverage() => this.beverageSize = Size.TALL;
        
        public abstract string Description { get; }
        public abstract decimal cost();
    }
}
