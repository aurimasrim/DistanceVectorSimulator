using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_vector_simulator
{
    class Neighbour
    {
        public int Id;
        public int Weight;
        
        public Neighbour(int id, int weight)
        {
            Id = id;
            Weight = weight;
        }
    }
}
