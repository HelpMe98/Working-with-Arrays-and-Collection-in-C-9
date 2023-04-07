using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRoute
	{
		public int Number { get; }
		public string Origin { get; }
		public string Destination { get; }
		public BusRoute(int number, string origin, string destination)
		{
			this.Number = number;
			this.Origin = origin;
			this.Destination = destination;
		}
		public override string ToString() => $"{Number}: {Origin} -> {Destination}";
	}
}