using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			BusRouteRepository repository = new BusRouteRepository();

			Console.WriteLine("Bạn đang ở đâu ?");
			string startingAt = Console.ReadLine()!;

			Console.WriteLine("Nơi bạn muốn đến?");
			string goingTo = Console.ReadLine()!;

			//1. using Array.Find
			//BusRoute[] routes = repository.FindBusesBetween(startingAt, goingTo);

			//if (routes.Length > 0)
			//	foreach (BusRoute route in routes)
			//		Console.WriteLine($"Bạn có thể đi tuyến {route}");
			//else
			//	Console.WriteLine($"Không có tuyến nào giữa {startingAt} và {goingTo}");

			//2. using HashSet
			BusRoute[] originRoutes = repository.FindBusesTo(startingAt);
			BusRoute[] destinationRoutes = repository.FindBusesTo(goingTo);

			var routes = new HashSet<BusRoute>(originRoutes);
			routes.IntersectWith(destinationRoutes);

			if (routes.Count > 0)
				foreach (BusRoute route in routes)
					Console.WriteLine($"Bạn có thể đi tuyến {route}");
			else
				Console.WriteLine($"Không có tuyến nào giữa {startingAt} và {goingTo}");

		}
    }
}
