using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_vector_simulator
{
    class Path : IComparable
    {
        public int Destination { get; set; }
        public int Weight { get; set; }
        public int NextHop { get; set; }
        public int HopCount { get; set; }
        public int LearnedFrom { get; set; }
        public Path(int destination, int weight, int nextHop, int hopCount)
        {
            Destination = destination;
            Weight = weight;
            NextHop = nextHop;
            HopCount = hopCount;
        }
        public int CompareTo(object obj)
        {
            return Destination.CompareTo(((Path)obj).Destination);
        }
    }
}
