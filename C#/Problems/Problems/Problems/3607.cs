using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3607 : IProblem
    {
        public bool Test()
        {
            var c = 5;
            var connections = new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } };
            var queries = new[] { new[] { 1, 3 }, new[] { 2, 1 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 1, 2 } };

            var expected = new[] { 3, 2, 3 };

            var result = ProcessQueries(c, connections, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ProcessQueries(int c, int[][] connections, int[][] queries)
        {
            var fu = new FindUnion(c);
            foreach (var conn in connections)
            {
                fu.Union(conn[0], conn[1]);
            }

            var grids = new Dictionary<int, SortedSet<int>>();
            for (int i = 1; i < c; ++i)
            {
                var group = fu.Find(i);
                if (!grids.ContainsKey(group))
                    grids[group] = new SortedSet<int> { i };
                else
                    grids[group].Add(i);
            }

            var result = new List<int>();
            foreach (var query in queries)
            {
                var group = fu.Find(query[1]);
                if (query[0] == 2)
                {
                    grids[group].Remove(query[1]);
                }
                else
                {
                    var value = grids[group].Count == 0 ? -1 : (grids[group].Contains(query[1]) ? query[1] : grids[group].Min);
                    result.Add(value);
                }
            }

            return result.ToArray();
        }

        private class FindUnion
        {
            private int[] _groups;
            private int[] _depth;

            public FindUnion(int n)
            {
                _groups = Enumerable.Range(0, n + 1).ToArray();
                _depth = Enumerable.Repeat(0, n + 1).ToArray();
            }

            public int Find(int x)
            {
                if (x == _groups[x])
                    return x;
                return Find(_groups[x]);
            }

            public void Union(int x, int y)
            {
                var pX = Find(x);
                var pY = Find(y);
                if (_depth[pY] < _depth[pX])
                {
                    _groups[pY] = pX;
                    _depth[pX] += _depth[pY];
                }
                else
                {
                    _groups[pX] = pY;
                    _depth[pY] += _depth[pX];
                }
            }
        }
    }
}
