using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2492 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var roads = new[] { new[] { 1, 2, 9 }, new[] { 2, 3, 6 }, new[] { 2, 4, 5 }, new[] { 1, 4, 7 } };

            var expected = 5;

            var result = MinScore(n, roads);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinScore(int n, int[][] roads)
        {
            var ngs = new List<int>[n];
            var edges = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                ngs[i] = new List<int>();
                edges[i] = new List<int>();
            }
            foreach (var r in roads)
            {
                var a = r[0] - 1;
                var b = r[1] - 1;
                ngs[a].Add(b);
                edges[a].Add(r[2]);
                ngs[b].Add(a);
                edges[b].Add(r[2]);
            }
            var visited = new bool[n];
            var queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            var result = int.MaxValue;
            while (queue.Count > 0)
            {
                var top = queue.Dequeue();
                var ct = ngs[top].Count;
                for (int i = 0; i < ct; ++i)
                {
                    var ng = ngs[top][i];
                    var edge = edges[top][i];
                    result = Math.Min(result, edge);
                    if (!visited[ng])
                    {
                        queue.Enqueue(ng);
                        visited[ng] = true;
                    }
                }
            }

            return result;
        }
    }
}
