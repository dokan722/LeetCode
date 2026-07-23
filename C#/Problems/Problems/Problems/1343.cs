using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1343 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 2, 2, 2, 5, 5, 5, 8 };
            var k = 3;
            var threshold = 4;

            var expected = 3;

            var result = NumOfSubarrays(arr, k, threshold);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            var n = arr.Length;
            var cur = 0;
            for (int i = 0; i < k; ++i)
                cur += arr[i];
            var result = cur / k >= threshold ? 1 : 0;
            for (int i = 0; i < n - k; ++i)
            {
                cur -= arr[i];
                cur += arr[i + k];
                if (cur / k >= threshold)
                    result++;
            }

            return result;
        }
    }
}
