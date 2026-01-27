using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3650 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var edges = new[] { new[] { 0, 1, 3 }, new[] { 3, 1, 1 }, new[] { 2, 3, 4 }, new[] { 0, 2, 2 } };

            var expected = 5;

            var result = MinCost(n, edges);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinCost(int n, int[][] edges)
        {
            var queue = new PriorityQueue<int, int>();
            var neighbours = new List<(int Edge, int Weigth)>[n];
            var dists = new int[n];
            neighbours[0] = new List<(int, int)>();
            for (int i = 1; i < n; ++i)
            {
                neighbours[i] = new List<(int, int)>();
                dists[i] = int.MaxValue;
            }
            foreach (var edge in edges)
            {
                neighbours[edge[0]].Add((edge[1], edge[2]));
                neighbours[edge[1]].Add((edge[0], 2 * edge[2]));
            }

            queue.Enqueue(0, 0);
            while (queue.TryDequeue(out var cur, out var curDist))
            {
                foreach (var neighbour in neighbours[cur])
                {
                    var newDist = curDist + neighbour.Weigth;
                    if (newDist < dists[neighbour.Edge])
                    {
                        dists[neighbour.Edge] = newDist;
                        queue.Enqueue(neighbour.Edge, newDist);
                    }
                }
            }

            return dists[n - 1] == int.MaxValue ? -1 : dists[n - 1];
        }
    }
}
