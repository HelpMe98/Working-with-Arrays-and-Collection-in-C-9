using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	public static class PassengerGenerator
	{
		private static int _count = 0;
		private static Random _rnd = new Random();
		public static Passenger CreatePassenger()
		{
			string destination = _rnd.Next(2) == 0 ? "Lancaster" : "Morecambe";
			return new Passenger($"Person {++_count}", destination);
		}
	}
}
