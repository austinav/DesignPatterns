using System;

namespace DesignPatterns.Patterns.Factory
{
    public abstract class Pizza
    {
        #region Members
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clams;
        #endregion Members

        #region Properties
        public string Name { get; set; }
        #endregion

        public abstract void prepare();
        public void bake() => Console.WriteLine("Bake for 25 minutes at 350");
        public void cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        public void box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public override string ToString() => base.ToString();
    }
}