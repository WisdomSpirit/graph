using System.Collections.Generic;

namespace GraphCycleFinder
{
    public class Node
    {
        public Node(int name)
        {
            NodeNumber = name;
        }

        public Node Parent;

        public readonly int NodeNumber;
        public readonly List<Node> IncidentNodes = new List<Node>();
    }
}