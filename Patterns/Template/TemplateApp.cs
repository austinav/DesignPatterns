using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Template
{
    class TemplateApp : App
    {
        public override void MainProgram()
        {
            Console.WriteLine("First, we instantiate a subclass of the template class");
            //Tea tea = new Tea();
            //Coffee coffee = new Coffee();

            //Console.WriteLine("\nMaking tea...");
            //tea.prepareRecipe();

            //Console.WriteLine("\nMaking coffee...");
            //coffee.prepareRecipe();


            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("Then we run the inherited method that hold the algorithm template");
            Console.WriteLine("\nMaking tea...");
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.prepareRecipe();
            Console.WriteLine();
        }
    }
}
