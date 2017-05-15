using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_vector_simulator
{
    class Router
    {
        public List<Neighbour> Neighbours;
        public int Id;
        public List<Path> Paths { get; set; }
        public Router(int id)
        {
            Id = id;
            Neighbours = new List<Neighbour>();
            Paths = new List<Path>();
            foreach(Neighbour n in Neighbours)
            {
                Paths.Add(new Path(n.Id, n.Weight, n.Id));
            }
        }
        public void AddNeighbour(int id, int weight)
        {
            if (Neighbours.Count(x => x.Id == id) != 0)
                throw new InvalidOperationException(id + " is already a neighbour of " + this.Id);
            Neighbours.Add(new Neighbour(id, weight));
            Paths.Add(new Path(id, weight, id));
        }
        public void RemoveNeighbour(int id)
        {
            if (!HasNeighbour(id))
                throw new InvalidOperationException(id + " is not a neighbour of " + this.Id);
            Neighbours.Remove(Neighbours.First(x => x.Id == id));
            //Neighbours.First(x => x.Id == id).Weight = -1;
            Path p = Paths.FirstOrDefault((x => (x.Destination == id) && (x.NextHop == id)));
            if (p != null)
            {
                //Paths.Remove(p);
                p.Weight = -1;
            }
        }
        public bool HasNeighbour(int id)
        {
            return Neighbours.Count(x => x.Id == id) != 0;
        }
        public void ChangeWeight(int id, int weight)
        {
            if (Neighbours.Count(x => x.Id == id) == 0)
                throw new InvalidOperationException(id + " is not a neighbour of " + this.Id);
            Neighbours.First(x => x.Id == id).Weight = weight;
        }
        
    }
}
