using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese() => new ReggianoCheese();
        public IClams createClams() => new FreshClams();
        public IDough createDough() => new ThinCrustDough();
        public IPepperoni createPepperoni() => new Pepperoni();
        public ISauce createSauce() => new MarinaSauce();
        public IVeggies[] createVeggies() => new IVeggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }

    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese() => new MozzarellaCheese();
        public IClams createClams() => new FrozenClams();
        public IDough createDough() => new ThickCrustDough();
        public IPepperoni createPepperoni() => new SlicedPepperoni();
        public ISauce createSauce() => new PlumTomatoSauce();
        public IVeggies[] createVeggies() => new IVeggies[] { new BlackOlive(), new Spinach(), new Eggplant() };
    }
}
