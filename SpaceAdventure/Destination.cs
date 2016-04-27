using System;

namespace spaceAdventureNameSpace
{
	public class DeterminDestination
	{
		public static void findDestination ()
		{
			var decision = "";
			while (decision != "Y" || decision != "N") 
			{
				decision = responceToPrompt ("Shall I choose a planet for you?");
				if (decision == "Y") 
				{
					ConsoleWriteLine ("Coordinates Recieved, traveling to...");
				}
				else if (decision == "N")
				{
					Console.WriteLine ("Ok where shall we go?");
				}
				else
				{
					Console.WriteLine ("Invalid Entry");
				}
			}
		}
		public static string responseToPrompt (string prompt)
		{
			Console.WriteLine (prompt);
			return Console.ReadLine ();
		}
	}
}