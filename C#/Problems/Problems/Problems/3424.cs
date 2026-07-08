using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3424 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { -7, 9, 5 };
            var brr = new[] { 7, -2, -5 };
            var k = 2;

            var expected = 13;

            var result = MinCost(arr, brr, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinCost(int[] arr, int[] brr, long k)
        {
            var n = arr.Length;
            long sortedResult = k;
            long unsortedResult = 0;
            var sorted = arr.OrderBy(x => x).ToArray();
            var order = Enumerable.Range(0, n).OrderBy(x => brr[x]).ToArray();
            for (int i = 0; i < n; ++i)
            {
                sortedResult += Math.Abs(sorted[i] - brr[order[i]]);
                unsortedResult += Math.Abs(arr[i] - brr[i]);
            }

            return Math.Min(sortedResult, unsortedResult);
        }
    }
}
