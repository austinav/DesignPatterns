using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
	public class FlyNoWay : IFly
	{
		public void fly()
		{
			Console.WriteLine("I can't fly");
		}
	}

	public class FlyWithWings : IFly
	{
		public void fly()
		{
			Console.WriteLine("I'm flying!!");
		}
	}

	public class FlyRocketPowered : IFly
	{
		public void fly()
		{
			Console.WriteLine("I'm flying with a rocket");
		}
	}

}
