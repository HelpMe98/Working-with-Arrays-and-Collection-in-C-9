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
		public static Passenger CreatePassenger()
		{
			string destination = "Lancaster";
			return new Passenger($"Person {++_count}", destination);
		}
	}
}
