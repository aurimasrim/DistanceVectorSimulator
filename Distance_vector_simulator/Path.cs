using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_vector_simulator
{
    class Path
    {
        public int Destination { get; set; }
        public int Weight { get; set; }
        public int NextHop { get; set; }
        public int
        public Path(int destination, int weight, int nextHop)
        {
            Destination = destination;
            Weight = weight;
            NextHop = nextHop;
        }
    }
}
