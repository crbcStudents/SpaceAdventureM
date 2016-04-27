using System;

namespace SpaceAdventure
{
	class SpaceAdventureMainClass
	{
		public static void Main (string[] args)
		{
			GreetingNameSpace.GreetingClass.greetAdventurer ();
			planetNameSpace.PlanetClass.PlanetIntroduction ();
			spaceShipNameSpace.SpaceShipClass.chooseASpaceShip ();
			spaceAdventureNameSpace.DeterminDestination.findDestination ();

		}
	}
}
