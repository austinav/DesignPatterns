using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
	public abstract class Duck
	{
		public IFly FlyBehavior { private get; set; }
		public IQuack QuackBehavior { private get; set; }

		public Duck() { }

		public abstract void display();

		public void performFly() => FlyBehavior.fly();

		public void performQuack() => QuackBehavior.quack();

		public void swim() => Console.WriteLine("All ducks float, even decoys!");
	}
}
