using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2685 : IProblem
    {
        public bool Test()
        {
            var n = 6;
            var edges = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 3, 5 } };

            var expected = 1;

            var result = CountCompleteComponents(n, edges);

            return result == expected;
        }

        public int CountCompleteComponents(int n, int[][] edges)
        {
            var fu = new FindUnionWithCount(n);
            foreach (var edge in edges)
            {
                fu.Union(edge[0], edge[1]);
            }

            var counts = new Dictionary<int, int>();

            foreach (var edge in edges)
            {
                var root = fu.Find(edge[0]);
                if (counts.ContainsKey(root))
                    counts[root]++;
                else
                    counts[root] = 1;
            }

            var result = 0;

            for (int i = 0; i < n; i++)
            {
                if (fu.Find(i) == i)
                {
                    if (!counts.ContainsKey(i))
                    {
                        result++;
                        continue;
                    }
                    var verCount = fu.Counts[i];
                    var edgeCount = verCount * (verCount - 1) / 2;
                    if (edgeCount == counts[i])
                        result++;
                }
            }

            return result;
        }

        protected class FindUnionWithCount
        {
            private int[] _vertices;
            public int[] Counts;

            public FindUnionWithCount(int n)
            {
                _vertices = Enumerable.Repeat(-1, n).ToArray();
                Counts = Enumerable.Repeat(1, n).ToArray();
            }

            public int Find(int x)
            {
                if (_vertices[x] != -1)
                {
                    _vertices[x] = Find(_vertices[x]);
                    return _vertices[x];
                }
                return x;
            }

            public void Union(int x, int y)
            {
                var root_x = Find(x);
                var root_y = Find(y);
                if (root_x != root_y)
                {
                    _vertices[root_x] = root_y;
                    Counts[root_y] += Counts[root_x];
                }
            }
        }

    }
}
