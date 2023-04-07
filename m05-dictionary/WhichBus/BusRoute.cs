using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRoute
	{
		public int Number { get; }
		public string Origin => PlacesServed[0];
		public string Destination => PlacesServed[^1];
		public string[] PlacesServed { get; }
		public BusRoute(int number, string[] placesServed)
		{
			this.Number = number;
			this.PlacesServed = placesServed;
		}
		public override string ToString() => $"{Number}: {Origin} -> {Destination}";
		public bool Serves(string destination)
		{
			return Array.Exists(PlacesServed, place => place == destination);
		}
	}
}