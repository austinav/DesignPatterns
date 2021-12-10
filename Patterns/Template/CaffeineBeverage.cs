using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Template
{
    public abstract class CaffeineBeverageWithHook
    {
		public void prepareRecipe()
		{
			boilWater();
			brew();
			pourInCup();
			if (customerWantsCondiments())
			{
				addCondiments();
			}
		}

		protected abstract void brew();

		protected abstract void addCondiments();

		protected void boilWater()
		{
			Console.WriteLine("Boiling water");
		}

		protected void pourInCup()
		{
			Console.WriteLine("Pouring into cup");
		}

		protected virtual bool customerWantsCondiments()
		{
			return true;
		}
	}
}
