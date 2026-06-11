using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3558 : IProblem
    {
        public bool Test()
        {
            var edges = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 3, 5 } };
            var expected = 2;

            var result = AssignEdgeWeights(edges);

            Console.WriteLine(result);

            return result == expected;
        }

        public int AssignEdgeWeights(int[][] edges)
        {
            var n = edges.Length + 1;
            var nbs = new List<int>[n + 1];
            for (int i = 0; i <= n; ++i)
                nbs[i] = new List<int>();
            foreach (var e in edges)
            {
                nbs[e[0]].Add(e[1]);
                nbs[e[1]].Add(e[0]);
            }

            var d = 0;
            var q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(0);
            var visited = new bool[n + 1];
            while (q.Count > 1)
            {
                var top = q.Dequeue();
                if (top != 0)
                {
                    visited[top] = true;
                    foreach (var nb in nbs[top])
                    {
                        if (!visited[nb])
                            q.Enqueue(nb);
                    }
                }
                else
                {
                    d++;
                    q.Enqueue(0);
                }
            }
            long res = 1;
            long b = 2;
            var mod = 1000000007;
            d--;
            while (d > 0)
            {
                if (d % 2 == 1)
                    res = res * b % mod;
                b = b * b % mod;
                d >>= 1;
            }

            return (int)res;
        }
    }
}
