using System;
using System.Collections.Generic;

namespace spaceShipNameSpace
{
	public class SpaceShipClass
	{
		public static void chooseASpaceShip ()
		{
			var numberOfChoices = 5;

			Console.WriteLine ("Please Chosse a ship");
			Console.WriteLine ("There are " + numberOfChoices + "in our fleet.");

			Dictionary<string, string> shipData = new Dictionary<string, string> (); 
			shipData ["The Red Commet"] = "The fastest and most agile in the fleet. Perfect for dramatic escapes!";
			shipData ["The Black Dragon"] = "Increadable stealth mode, for creep'n like a boss.";
			shipData ["The Green Beast"] = "This one has cannons. Bitches love cannons!";
			shipData ["The Purple Nerple"] = "Perfectly proceeds a puple portle.";
			shipData ["The Sparkle Fairy"] = "Probably the most fabulous ship, Glitters like the mid morning sun.";

		}
	}
}


