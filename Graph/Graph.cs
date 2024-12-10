using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {
        public List<string> Nodos { get; set; }
        public List<(string, string, int)> Aristas { get; set; } // (nodoA, nodoB, peso)

        public Graph()
        {
            Nodos = new List<string>();
            Aristas = new List<(string, string, int)>();
        }

        public void AddNode(string name)
        {
            if (!Nodos.Contains(name))
                Nodos.Add(name);
        }

        public void AddAristas(string nodeA, string nodeB, int weight = 1)
        {
            Aristas.Add((nodeA, nodeB, weight));
        }
    }
}
