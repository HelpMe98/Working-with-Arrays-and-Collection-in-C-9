using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
			BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

			BusRoute[] routes =
			{
				route40,
				route42,
				new BusRoute(100, "University", "Morecambe"),
				new BusRoute(555, "Lancaster", "Keswick")
			};

            Console.WriteLine("Tìm kiếm phần tử riêng lẻ:");
            Console.WriteLine($"Tuyến đường số 3 là {routes[2]}");
			BusRoute lastRoute = routes[^1]; // hoặc routes[routes.Length - 1]

            Console.WriteLine($"Tuyến đường cuối cùng là {lastRoute}");

            Console.WriteLine("Liệt kê với vòng lặp for");
            for (int i=0; i<routes.Length; i++)
			{
                Console.WriteLine($"{i} : {routes[i]}");
            }

            //foreach (BusRoute route in routes)
            //	Console.WriteLine(route);
        }
	}
}
