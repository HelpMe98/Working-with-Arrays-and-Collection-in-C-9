using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - _passengers.Count; }

        private Stack<Passenger> _passengers = new Stack<Passenger>();
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passengers.Push(passenger);
            Console.WriteLine($"{passenger} lên xe Bus");
            return true;
        }

        public void ArriveAtTerminus()
        {
            Console.WriteLine("\r\nXe Bus đến bến xe");
            while (_passengers.Count > 0)
            {
                Passenger passenger = _passengers.Pop();
                Console.WriteLine($"{passenger} xuông khỏi xe Bus");
            }

            Console.WriteLine($"Vẫn còn {_passengers.Count} trên xe Bus");
        }
    }
}
