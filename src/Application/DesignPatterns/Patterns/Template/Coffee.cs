using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Template
{
	public class CoffeeWithHook : CaffeineBeverageWithHook
	{


	protected override void brew()
	{
		Console.WriteLine("Dripping Coffee through filter");
	}

	protected override void addCondiments()
	{
		Console.WriteLine("Adding Sugar and Milk");
	}

	protected override bool customerWantsCondiments()
	{
		string answer = getUserInput();

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
		String answer = null;

		Console.Write("Would you like milk and sugar with your coffee (y/n)? ");
		
		TextReader instream = Console.In;
		//BufferedReader in = knew BufferedReader(new InputStreamReader(System.in));
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
