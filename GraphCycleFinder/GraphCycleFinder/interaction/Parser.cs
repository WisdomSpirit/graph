using System.Collections.Generic;
using System.Linq;

namespace GraphCycleFinder.interaction
{
    public static class Parser
    {
        // Из текстового файла получаем граф
        public static List<Node> Parse(List<string> list)
        {
            var graph = new List<Node>();
            var j = int.Parse(list.First());
            for (var i = 1; i <= j; i++)
            {
                graph.Add(new Node(i));
            }
            list.RemoveAt(0);
            var hostNode = 0;
            foreach (var str in list)
            {
                if (str == null) continue;
                var charset = str.Split(' ');
                var intset = charset
                    .Select(int.Parse)
                    .ToList();
                var obj = graph[hostNode];
                var incidentNode = 0;
                while (intset[incidentNode] != 0)
                {
                    obj.IncidentNodes.Add(graph[intset[incidentNode]-1]);
                    incidentNode++;
                }
                hostNode++;
            }
            return graph;
        }
    }
}