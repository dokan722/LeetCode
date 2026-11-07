using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1385 : IProblem
    {
        public bool Test()
        {
            var arr1 = new[] { 4, 5, 8 };
            var arr2 = new[] { 10, 9, 1, 8 };
            var d = 2;

            var expected = 2;

            var result = FindTheDistanceValue(arr1, arr2, d);

            return result == expected;
        }

        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            var n = arr1.Length;
            var m = arr2.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var close = false;
                for (int j = 0; j < m; ++j)
                {
                    if (Math.Abs(arr1[i] - arr2[j]) <= d)
                    {
                        close = true;
                        break;
                    }
                }
                if (!close)
                    result++;
            }

            return result;
        }
    }
}
