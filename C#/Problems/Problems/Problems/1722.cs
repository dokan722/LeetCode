using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1722 : IProblem
    {
        public bool Test()
        {
            var source = new[] { 1, 2, 3, 4 };
            var target = new[] { 2, 1, 4, 5 };
            var allowedSwaps = new[] { new[] { 0, 1 }, new[] { 2, 3 } };

            var expected = 1;

            var result = MinimumHammingDistance(source, target, allowedSwaps);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps)
        {
            var n = source.Length;
            var uf = new UF(n);
            foreach (var swap in allowedSwaps)
                uf.Union(swap[0], swap[1]);
            var counts = new Dictionary<int, Dictionary<int, int>>();
            for (int i = 0; i < n; ++i)
            {
                var p = uf.Find(i);
                if (!counts.ContainsKey(p))
                    counts[p] = new();
                if (counts[p].ContainsKey(source[i]))
                    counts[p][source[i]]++;
                else
                    counts[p][source[i]] = 1;
                if (counts[p].ContainsKey(target[i]))
                    counts[p][target[i]]--;
                else
                    counts[p][target[i]] = -1;
            }
            var result = 0;
            foreach (var count in counts.Values)
            foreach (var c in count.Values)
                result += Math.Abs(c);
            return result / 2;
        }

        private class UF
        {
            public int[] _uf;
            private int[] _d;
            public UF(int n)
            {
                _uf = Enumerable.Range(0, n).ToArray();
                _d = Enumerable.Repeat(1, n).ToArray();
            }

            public int Find(int x)
            {
                if (_uf[x] != x)
                    return _uf[x] = Find(_uf[x]);
                return _uf[x];
            }

            public void Union(int x, int y)
            {
                var pX = Find(x);
                var pY = Find(y);
                if (_d[pX] > _d[pY])
                    _uf[pY] = _uf[pX];
                else if (_d[pX] < _d[pY])
                    _uf[pX] = _uf[pY];
                else
                {
                    _uf[pY] = _uf[pX];
                    _d[pX]++;
                }
            }
        }
    }
}
