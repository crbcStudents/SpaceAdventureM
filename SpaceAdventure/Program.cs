using System;

namespace SpaceAdventure
{
	class SpaceAdventureMainClass
	{
		public static void Main (string[] args)
		{
			GreetingNameSpace.GreetingClass.greetAdventurer ();
			spaceShipNameSpace.SpaceShipClass.chooseASpaceShip ();
			chooseShipNameSpace.ChooseShipClass.ChooseShip ();
			planetNameSpace.PlanetClass.PlanetIntroduction ();
			destinationNameSpace.DeterminDestination.findDestination ();
		}
	}
}
