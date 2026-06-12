using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3559 : IProblem
    {
        public bool Test()
        {
            var edges = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 3, 5 } };
            var queries = new[] { new[] { 1, 4 }, new[] { 3, 4 }, new[] { 2, 5 } };

            var expected = new [] { 2, 1, 4 };

            var result = AssignEdgeWeights(edges, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] AssignEdgeWeights(int[][] edges, int[][] queries)
        {
            var n = edges.Length + 1;
            var m = queries.Length;
            var nbs = new List<int>[n + 1];
            var maxDepth = (int)(Math.Log(n) / Math.Log(2)) + 1;
            var parents = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
            {
                nbs[i] = new List<int>();
                parents[i] = new int[maxDepth];
            }
            foreach (var e in edges)
            {
                nbs[e[0]].Add(e[1]);
                nbs[e[1]].Add(e[0]);
            }
            var d = 0;
            var que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(0);
            var visited = new bool[n + 1];
            var depth = new int[n + 1];
            while (que.Count > 1)
            {
                var top = que.Dequeue();
                if (top != 0)
                {
                    visited[top] = true;
                    depth[top] = d;
                    foreach (var nb in nbs[top])
                    {
                        if (!visited[nb])
                        {
                            que.Enqueue(nb);
                            parents[nb][0] = top;
                        }
                    }
                }
                else
                {
                    d++;
                    que.Enqueue(0);
                }
            }
            for (int i = 1; i <= n; ++i)
                for (int j = 1; j < maxDepth; ++j)
                    parents[i][j] = parents[parents[i][j - 1]][j - 1];
            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                var u = queries[i][0];
                var v = queries[i][1];
                if (u == v)
                    continue;
                int p = depth[u] > depth[v] ? u : v;
                var q = depth[u] > depth[v] ? v : u;
                for (int j = maxDepth - 1; j >= 0; j--)
                {
                    if (depth[q] <= depth[parents[p][j]])
                        p = parents[p][j];
                }
                if (p != q)
                {
                    for (int j = maxDepth - 1; j >= 0; j--)
                    {
                        if (parents[p][j] != parents[q][j])
                        {
                            p = parents[p][j];
                            q = parents[q][j];
                        }
                    }
                    p = parents[p][0];
                }
                var pow = depth[v] + depth[u] - 2 * depth[p] - 1;
                long res = 1;
                long b = 2;
                var mod = 1000000007;
                while (pow > 0)
                {
                    if (pow % 2 == 1)
                        res = res * b % mod;
                    b = b * b % mod;
                    pow >>= 1;
                }

                result[i] = (int)res;
            }
            return result;
        }
    }
}
