using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRouteRepository
	{
		public static SortedDictionary<int, BusRoute> InitializeRoutes()
		{

			BusRoute route42 = new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" });
			BusRoute route40 = new BusRoute(40, new string[] {
					"Morecambe", "Lancaster", "Garstang", "Preston" });
			BusRoute route100 = new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" });
			BusRoute route555 = new BusRoute(555, new string[] {
					"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" });
			BusRoute route5 = new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth" });

			var routes = new SortedDictionary<int, BusRoute>
			{
				{ 42, route42 },
				{ 40, route40 },
				{ 100, route100 },
				{ 555, route555 },
				{ 5, route5 }
			};
			return routes;
		}

	}
}
