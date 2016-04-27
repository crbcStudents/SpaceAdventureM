using System;
using System.Collections.Generic;

namespace planetNameSpace
{
	public class PlanetClass
	{
		public static void PlanetIntroduction ()
		{
			var numberOfPlanets = 8;
			var diameterOfEarth = 24859;

			Console.WriteLine ("Welcome to our solar system");
			Console.WriteLine ("There are " + numberOfPlanets + "in this solar system.");

			Dictionary<string, string> planetData = new Dictionary <string, string> (); 
			planetData ["Mercury"] = "Mercury is the closest planet to the Sun";
			planetData ["Venus"] = "Venus is the second brightest object in the night sky after the Moon.";
			planetData ["Earth"] = "The Earth is the only planet in our solar system not to be named after a Greek or Roman deity.";
			planetData ["Mars"] = "Mars is also often described as the “Red Planet” due to its reddish appearance.";
			planetData ["Jupiter"] = "Jupiter is two and a half times more massive than all the other planets in the solar system combined";
			planetData ["Saturn"] = "Saturn is the second largest planet and is best known for its fabulous ring system";
			planetData ["Uranus"] = "Uranus was the first planet discovered with the use of a telescope.";
			planetData ["Neptune"] = "Neptune the most distant in the solar system.";

		}
	}
}
