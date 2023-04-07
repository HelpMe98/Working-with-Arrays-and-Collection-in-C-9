using System;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Passenger
    {
        public string Name { get; init; }
        public string Destination { get; init; }
        public Passenger(string name, string destination)
        {
            this.Name = name;
            this.Destination = destination;
        }
        public override string ToString() => $"{Name} to {Destination}";
	}
}