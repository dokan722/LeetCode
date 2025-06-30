using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1743 : IProblem
    {
        public bool Test()
        {
            var adjacentPairs = new int[][] { new int[] { 2, 1 }, new int[] { 3, 4 }, new int[] { 3, 2 } };

            var expected = new int[] { 1, 2, 3, 4 };

            var result = RestoreArray(adjacentPairs);

            Console.WriteLine(string.Join(",", result));

            return result.SequenceEqual(expected);
        }

        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var graph = new Dictionary<int, List<int>>();
            foreach (var pair in adjacentPairs)
            {
                if (graph.ContainsKey(pair[0]))
                    graph[pair[0]].Add(pair[1]);
                else
                    graph[pair[0]] = new List<int> { pair[1]} ;
                if (graph.ContainsKey(pair[1]))
                    graph[pair[1]].Add(pair[0]);
                else
                    graph[pair[1]] = new List<int> { pair[0] };
            }

            var root = graph.First(x => x.Value.Count == 1).Key;
            var result = new List<int> { root };
            DfsListGraph(graph, root, null, result);


            return result.ToArray();
        }

        private void DfsListGraph(Dictionary<int, List<int>> graph, int curr, int? prev, List<int> result)
        {
            foreach (var n in graph[curr])
            {
                if (n != prev)
                {
                    result.Add(n);
                    DfsListGraph(graph, n, curr, result);
                }
            }
        }
    }
}
