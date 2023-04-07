using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRoute
	{
		public int Number { get; }
		public string[] PlacesServed { get; }
		public string Origin => PlacesServed[0];
		public string Destination => PlacesServed[^1];

		public BusRoute(int number, string[] placesServed)
		{
			this.Number = number;
			this.PlacesServed = placesServed;
		}
		public override string ToString() => $"{Number}: {PlacesServed[0]} -> {PlacesServed[^1]}";

		public bool Serves(string destination)
		{
			return Array.Find(PlacesServed, place => place == destination) != null;
		}
	}
}