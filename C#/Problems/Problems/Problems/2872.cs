using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2872 : IProblem
    {
        public bool Test()
        {
            var n = 5;
            var edges = new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } };
            var values = new[] { 1, 8, 1, 4, 4 };
            var k = 6;

            var expected = 2;

            var result = MaxKDivisibleComponents(n, edges, values, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
        {
            var graph = new List<int>[n];
            for (int i = 0; i < n; ++i)
                graph[i] = new();
            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            DFS(0, -1, graph, values, k);

            return _count;
        }

        private int _count = 0;
        private int DFS(int e, int prev, List<int>[] graph, int[] values, int k)
        {
            var sum = values[e];
            foreach (var n in graph[e])
            {
                if (n != prev)
                    sum += DFS(n, e, graph, values, k);
                sum %= k;
            }

            if (sum % k == 0)
                _count++;


            return sum;
        }
    }
}
