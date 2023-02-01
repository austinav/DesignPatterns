using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
	public class Quack : IQuack
	{
		public void quack()
		{
			Console.WriteLine("Quack");
		}
	}

	public class MuteQuack : IQuack
	{
		public void quack()
		{
			Console.WriteLine("<< Silence >>");
		}
	}

	public class Squeak : IQuack
	{
		public void quack()
		{
			Console.WriteLine("Squeak");
		}
	}


	public class FakeQuack : IQuack
	{
		public void quack()
		{
			Console.WriteLine("Qwak");
		}
	}
}
