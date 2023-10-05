using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Patterns.Strategy;

namespace DesignPatterns.Patterns.Strategy
{
	public class ModelDuck : Duck
	{
		public ModelDuck()
		{
			FlyBehavior = new FlyNoWay();
			QuackBehavior = new Quack();
		}

		public override void display()
		{
			Console.WriteLine("I'm a model duck");
		}
	}
	public class RedHeadDuck : Duck
	{
		public RedHeadDuck()
		{
			FlyBehavior = new FlyWithWings();
			QuackBehavior = new Quack();
		}

		public override void display()
		{
			Console.WriteLine("I'm a real Red Headed duck");
		}
	}

	public class RubberDuck : Duck
	{
		public RubberDuck()
		{
			FlyBehavior = new FlyNoWay();
			QuackBehavior = new Squeak();
			//QuackBehavior = () => Console.WriteLine("Squeak"); //can't do Functional interfaces in Java, C# forces choice of interface or delegate
		}

		public RubberDuck(IFly flyBehavior, IQuack quackBehavior)
		{
			FlyBehavior = flyBehavior;
			QuackBehavior = quackBehavior;
		}

		public override void display()
		{
			Console.WriteLine("I'm a rubber duckie");
		}
	}
	
	
	public class DecoyDuck : Duck
	{
		public DecoyDuck()
		{
			FlyBehavior = new FlyNoWay();
			QuackBehavior = new MuteQuack();
		}

		public override void display()
		{
			Console.WriteLine("I'm a duck Decoy");
		}
	}

	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			QuackBehavior = new Quack();
			FlyBehavior = new FlyWithWings();
		}

		public override void display()
		{
			Console.WriteLine("I'm a real Mallard duck");
		}
	}
}
