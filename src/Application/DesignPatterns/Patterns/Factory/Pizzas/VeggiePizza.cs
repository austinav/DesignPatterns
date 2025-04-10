using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Patterns.Factory.Ingredients;

namespace DesignPatterns.Patterns.Factory.Pizzas
{
    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            veggies = ingredientFactory.createVeggies();
        }
    }
}
