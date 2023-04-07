using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRouteRepository repository = new BusRouteRepository();

			BusTimes times5 = repository.BusTimesRoute5;
			BusRoute route5 = times5.Route;

            // using dimensional array
            //for (int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
            //{
            //	Console.Write(route5.PlacesServed[iPlace].PadRight(12));

            //	for (int iJourney = 0; iJourney < times5.Times.GetLength(1); iJourney++)
            //		Console.Write(times5.Times[iPlace, iJourney] + " ");
            //	Console.WriteLine();
            //}

            // using jagged array
            for (int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
            {
                Console.Write(route5.PlacesServed[iPlace].PadRight(12));

                foreach(var time in times5.Times[iPlace])
                    Console.Write(time + " ");
                Console.WriteLine();
            }
        }
    }
}
