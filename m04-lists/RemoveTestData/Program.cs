using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine($"Trước: Có {allRoutes.Count} tuyến:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Tuyến: {route}");

			allRoutes.RemoveAll(route => route.Origin.StartsWith("Test"));

			Console.WriteLine($"\r\nSau: Có {allRoutes.Count} tuyến:");
			foreach (BusRoute route in allRoutes)
				Console.WriteLine($"Tuyến: {route}");
		}
	}
}
