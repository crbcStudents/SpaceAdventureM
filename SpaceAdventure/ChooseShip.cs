﻿using System;

namespace chooseShipNameSpace
{
	public class ChooseShipClass 
	{
		public static void ChooseShip ()
		{
			var decision = "";
			while (decision != "Y" || decision != "N") 
			{
				decision = responseToPrompt ("Shall I choose a planet for you?");
				if (decision == "Y") 
				{
					Console.WriteLine ("Coordinates Recieved, traveling to...");
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

