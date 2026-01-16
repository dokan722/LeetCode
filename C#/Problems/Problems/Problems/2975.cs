using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2975 : IProblem
    {
        public bool Test()
        {
            var m = 4;
            var n = 3;
            var hFences = new[] { 2, 3 };
            var vFences = new[] { 2 };

            var expected = 4;

            var result = MaximizeSquareArea(m, n, hFences, vFences);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
        {
            var hn = hFences.Length;
            var hDists = new HashSet<int> { m - 1 };
            for (int i = 0; i < hn; ++i)
            {
                for (int j = i + 1; j < hn; ++j)
                    hDists.Add(Math.Abs(hFences[i] - hFences[j]));
                hDists.Add(Math.Abs(1 - hFences[i]));
                hDists.Add(Math.Abs(m - hFences[i]));
            }
            var vn = vFences.Length;
            var vDists = new HashSet<int> { n - 1 };
            for (int i = 0; i < vn; ++i)
            {
                for (int j = i + 1; j < vn; ++j)
                    vDists.Add(Math.Abs(vFences[i] - vFences[j]));
                vDists.Add(Math.Abs(1 - vFences[i]));
                vDists.Add(Math.Abs(n - vFences[i]));
            }

            var side = 0;
            foreach (var hDist in hDists)
            {
                if (vDists.Contains(hDist))
                    side = Math.Max(side, hDist);
            }

            return side == 0 ? -1 : (int)((long)side * side % 1000000007);
        }
    }
}
