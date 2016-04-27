using System;

namespace GreetingNameSpace
{
	public class GreetingClass
	{

		public static string responseToPrompt(string prompt)
		{
			Console.WriteLine (prompt);
			return Console.ReadLine ();
		}

		public static void greetAdventurer()
		{
			var name = responseToPrompt ("What your name?");
			Console.WriteLine("Nice to meet you " + name + "!");
		}

		public static void determineDestination ()
		{
			var decision = "";

			while (decision != "Y" || decision != "N") 
			{
				decision = responseToPrompt ("Shall I randomly choose a planet for you to visit? (Y or N)");

				if (decision == "Y") 
				{
					Console.WriteLine ("Yes");
					Console.ReadLine (visit (planetName: ""));
					visit (planetName: "");

				} 
				else if (decision == "N") 
				{
					Console.WriteLine ("No");
				} 
				else 
				{
					Console.WriteLine ("Invalid Choice");
				}
					

			}
		}

		public static void visit(string planetName)
		{
			Console.WriteLine ("Travelling to " + planetName + "!");
		}
				

	}
}

