using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			var allRoutes = BusRouteRepository.InitializeRoutes();

			Console.WriteLine("Tuyến Bus bạn muốn tìm tiếm?");
			int number = int.Parse(Console.ReadLine()!);

			// using indexer. This will throw an exception if number doesn't exist
			// so you'll need to comment these lines out to test TryGetValue and ContainsKey 
			// with numbers that don't exist
			BusRoute answer = allRoutes[number];
			if (answer != null)
				Console.WriteLine($"Tuyến bạn tìm kiếm là {answer}");
			else
				Console.WriteLine($"Không có tuyến sô {number}");

			// using TryGetValue()
			bool success = allRoutes.TryGetValue(number, out BusRoute? answer2);
			if (success)
				Console.WriteLine($"Tuyến bạn tìm kiếm là {answer2}");
			else
				Console.WriteLine($"Không có tuyến số {number}");

			// using ContainsKey()
			bool success2 = allRoutes.ContainsKey(number);
			if (success2)
				Console.WriteLine($"Tuyến bạn tìm kiếm là {allRoutes[number]}");
			else
				Console.WriteLine($"Không có tuyến số {number}");

			// using SortedDictionary
            Console.WriteLine("Danh sách tuyến Bus: ");
            foreach (var route in allRoutes.Values)
			{
                Console.WriteLine(route);
            }
		}
	}
}
