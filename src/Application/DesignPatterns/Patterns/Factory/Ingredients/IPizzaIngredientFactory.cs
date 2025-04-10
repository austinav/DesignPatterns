using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        public IDough createDough();

        public ISauce createSauce();

        ICheese createCheese();

        IVeggies[] createVeggies();

        IPepperoni createPepperoni();

        IClams createClams();

    }
}
