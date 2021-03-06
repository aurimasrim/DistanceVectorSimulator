﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Distance_vector_simulator
{
    class Network
    {
        List<Router> Routers;
        public Network()
        {
            Routers = new List<Router>();
        }

        public Router AddRouter(int id)
        {
            if (Routers.Count(x => x.Id == id) != 0)
                throw new ArgumentException();
            Router router = new Router(id);
            Routers.Add(router);
            return router;
        }
        public void RemoveRouter(int id)
        {
            if (Routers.Count(x => x.Id == id) == 0)
                throw new ArgumentException();
            Routers.Remove(Routers.First(x => x.Id == id));
            foreach(Router r in Routers)
            {
                if (r.HasNeighbour(id))
                {
                    r.RemoveNeighbour(id);
                }
                    
            }
        }
        public void ChangeWeight(int id1, int id2, int weight)
        {
            if (weight <= 0)
                throw new ArgumentException("Bad weight");
            try
            {
                Routers.First(x => x.Id == id1).ChangeWeight(id2, weight);
                Routers.First(x => x.Id == id2).ChangeWeight(id1, weight);
            }
            catch (InvalidOperationException exc)
            {
                throw;
            }
        }
        public void AddLink(int id1, int id2, int weight)
        {
            if (weight <= 0)
                throw new ArgumentException("Bad weight");
            try
            {
                Router temp = Routers.First(x => x.Id == id1);
                temp.AddNeighbour(id2, weight);
                temp.SortPaths();
                temp = Routers.First(x => x.Id == id2);
                temp.AddNeighbour(id1, weight);
                temp.SortPaths();
            }
            catch (InvalidOperationException exc)
            {
                throw;
            }
        }
        public void RemoveLink(int id1, int id2)
        {
            try
            {
                Routers.First(x => x.Id == id1).RemoveNeighbour(id2);
                Routers.First(x => x.Id == id2).RemoveNeighbour(id1);
            }
            catch (InvalidOperationException exc)
            {
                throw;
            }
        }
        public void DoIteration()
        {
            for (int i = 0; i < Routers.Count; i++)
            {
                for (int j = 0; j < Routers[i].Neighbours.Count; j++)
                {
                    SendInfo(Routers[i].Id, Routers[i].Neighbours[j].Id);
                }
            }
        }
        public void SendInfo(int from, int to)
        {
            Router rFrom = Routers.First(x => x.Id == from);
            Router rTo = Routers.First(x => x.Id == to);
            foreach(Path pNew in rFrom.Paths)
            {
                rTo.ChangePath(pNew, from, true);
            }
            rTo.SortPaths();
            //r2.Paths.First(x => x.Destination)
        }
    }
}
