using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRoute
	{
		public int Number { get; }
		public string Origin => ServesPlaced[0];
		public string Destination => ServesPlaced[^1];
		public string[] ServesPlaced { get; }
		public BusRoute(int number, string[] servesplaced)
		{
			this.Number = number;
			this.ServesPlaced = servesplaced;
		}
		public override string ToString() => $"{Number}: {Origin} -> {Destination}";

		public bool Served(string location) => Array.Exists(ServesPlaced, place => place.Equals(location));
	}
}