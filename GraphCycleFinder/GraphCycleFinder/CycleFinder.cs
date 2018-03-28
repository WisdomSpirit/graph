using System.Collections.Generic;
using System.Linq;

namespace GraphCycleFinder
{
    public static class CycleFinder
    {
        public static List<int> Cycle(List<Node> graph)
        {
            var grey = new List<Node>();
            var black = new List<Node>();
            var stack = new Stack<Node>();
            graph.First().Parent = null;
            stack.Push(graph.First());
            grey.Add(graph.First());
            while (stack.Count != 0)
            {
                var node = stack.Pop();
                foreach (var nextNode in node.IncidentNodes)
                {
                    if (black.Contains(nextNode)) continue;
                    if (grey.Contains(nextNode))
                    {
                        var result = new List<int>();
                        var fin = nextNode.Parent;
                        var curr = node;
                        result.Add(nextNode.NodeNumber);
                        while (curr != fin)
                        {
                            result.Add(curr.NodeNumber);
                            curr = curr.Parent;
                        }
                        result.Add(curr.NodeNumber);

                        return result.OrderBy(e => e).ToList();
                    }
                    stack.Push(nextNode);
                    grey.Add(nextNode);
                    nextNode.Parent = node;
                }
                black.Add(node);
            }
            return null;
        }
    }
}