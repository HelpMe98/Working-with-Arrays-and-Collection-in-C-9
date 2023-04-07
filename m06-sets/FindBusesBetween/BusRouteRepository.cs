using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	public class BusRouteRepository
	{
		private readonly BusRoute[] _allRoutes;
		public BusRouteRepository()
		{
			_allRoutes = new BusRoute[] {
				new BusRoute(40, new string[] {
					"Morecambe", "Lancaster", "Garstang", "Preston" }),
				new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
				new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
				new BusRoute(555, new string[] {
					"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
				new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth"})
			};
		}
		public BusRoute[] FindBusesTo(string location)
		{
			return Array.FindAll(_allRoutes, route => route.Serves(location));
		}
		public BusRoute[] FindBusesBetween(string location1, string location2)
		{
			return Array.FindAll(_allRoutes,
				route => route.Serves(location1) && route.Serves(location2));
		}
	}
}
