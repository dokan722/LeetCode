using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1477 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 3, 2, 2, 4, 3 };
            var target = 3;

            var expected = 2;

            var result = MinSumOfLengths(arr, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSumOfLengths(int[] arr, int target)
        {
            var n = arr.Length;
            var result = int.MaxValue;
            var prev = new int[n];
            var prefs = new Dictionary<int, int>();
            prefs[0] = -1;
            var bestF = n + 1;
            var cur = 0;
            for (int i = 0; i < n; ++i)
            {
                cur += arr[i];
                prefs[cur] = i;
                var req = cur - target;
                if (prefs.ContainsKey(req))
                {
                    var s = prefs[req];
                    var l = i - s;
                    if (bestF != n + 1 && prev[s] != n + 1)
                    {
                        result = Math.Min(result, l + prev[s]);
                    }
                    bestF = Math.Min(bestF, l);
                }
                prev[i] = bestF;
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
