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

        private LinkedList<Passenger> _passengers = new LinkedList<Passenger>();
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passengers.AddLast(passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }
        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;

            LinkedListNode<Passenger>? currentNode = _passengers.First;
            do{
                LinkedListNode<Passenger>? nextNode = currentNode!.Next;
                if (currentNode.Value.Destination == place)
                {
                    Console.WriteLine($"{currentNode.Value} is getting off");
                    _passengers.Remove(currentNode);
                }
                currentNode = nextNode;
            } while (currentNode != null);
            Console.WriteLine($"{_passengers.Count} people left on the bus");
        }
    }
}
