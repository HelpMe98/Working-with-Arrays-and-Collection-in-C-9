using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine("Bạn muốn đi đâu ?");
			string location = Console.ReadLine()!;

			BusRoute[] routes = FindBusesTo(allRoutes, location);

			if (routes.Length > 0) 
			{
				foreach (var route in routes)
				{
                    Console.WriteLine($"Bạn có thể dùng tuyến {route}");
                }
            }
            else
				Console.WriteLine($"Không có tuyến nào đi đến {location}");
		}

        private static BusRoute[] FindBusesTo(BusRoute[] allRoutes, string location)
        {
			return Array.FindAll(allRoutes, route => route.Served(location));
        }

        public static BusRoute? FindBusTo(BusRoute[] routes, string location)
		{
            //foreach (BusRoute route in routes)
            //{
            //	if (route.Origin == location || route.Destination == location)
            //		return route;
            //}
            //return null;

            return Array.Find(routes, route => route.Served(location));
		}


	}
}
