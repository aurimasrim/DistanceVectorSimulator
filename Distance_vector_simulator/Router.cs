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
        public const int _maxHopCount = 10;
        public Router(int id)
        {
            Id = id;
            Neighbours = new List<Neighbour>();
            Paths = new List<Path>();
            foreach(Neighbour n in Neighbours)
            {
                Paths.Add(new Path(n.Id, n.Weight, n.Id, 1));
            }
        }
        public void AddNeighbour(int id, int weight)
        {
            if (Neighbours.Count(x => x.Id == id) != 0)
                throw new InvalidOperationException(id + " is already a neighbour of " + this.Id);
            Neighbours.Add(new Neighbour(id, weight));
            ChangePath(new Path(id, weight, id, 1), id, false);
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
            for (int i = 0; i < Paths.Count; i++)
            {
                if (Paths[i].NextHop == id)
                {
                    int pathDest = Paths[i].Destination;
                    if (!HasNeighbour(pathDest))
                    {
                        Paths[i].Weight = -1;
                    }
                    else
                    {
                        Paths.RemoveAt(i);
                        Neighbour n = Neighbours.First(x => x.Id == pathDest);
                        ChangePath(new Path(n.Id, n.Weight, n.Id, 1), n.Id, false);
                    }
                }
                
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
            ChangePath(new Path(id, weight, id, 1), id, false);
        }
        public void ChangePath(Path pNew, int from, bool calculateWeight)
        {
            if (pNew.Destination == Id)
                return;
            Path pOld = Paths.FirstOrDefault(x => x.Destination == pNew.Destination);

            int weightNew;
            if (!calculateWeight)
            {
                weightNew = pNew.Weight;
            }
            else if (pNew.Weight == -1)
                weightNew = -1;
            else
                weightNew = pNew.Weight + Neighbours.First(x => x.Id == from).Weight;

            if (pNew.HopCount >= _maxHopCount)
            {
                Paths.Remove(pOld);
                Paths.Add(new Path(pNew.Destination, -1, pNew.NextHop, -1));
            }
            else if (pOld == null)
            {
                if (calculateWeight)
                    Paths.Add(new Path(pNew.Destination, weightNew, from, pNew.HopCount + 1));
                else
                    Paths.Add(new Path(pNew.Destination, weightNew, from, pNew.HopCount));
            }
            else if (pNew.NextHop == pOld.NextHop || pOld.Weight == -1 || (weightNew < pOld.Weight && weightNew != -1))
            {
                int hopCount = pNew.HopCount;
                if (calculateWeight)
                    hopCount++;
                Paths.Remove(pOld);
                Paths.Add(new Path(pNew.Destination, weightNew, from, hopCount));
            }
        }
        public void SortPaths()
        {
            Paths.Sort();
        }
    }
}
