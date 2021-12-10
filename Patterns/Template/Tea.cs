using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Template
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
		protected override void brew()
		{
			Console.WriteLine("Steeping the tea");
		}

		protected override void addCondiments()
		{
			Console.WriteLine("Adding Lemon");
		}

		protected override bool customerWantsCondiments()
		{

			String answer = getUserInput();

			if (answer.ToLower().StartsWith("y"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private String getUserInput()
		{
			// get the user's response
			String answer = null;

			Console.Write("Would you like lemon with your tea (y/n)? ");

			TextReader instream = Console.In;
			try
			{
				answer = instream.ReadLine();
			}
			catch (IOException ioe)
			{
				Console.WriteLine("IO error trying to read your answer");
			}
			if (answer == null)
			{
				return "no";
			}
			return answer;
		}
	}
}
