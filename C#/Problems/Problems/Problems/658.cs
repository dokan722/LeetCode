using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _658 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8 };
            var k = 3;
            var x = 5;

            var expected = new[] { 3, 3, 4 };

            var result = FindClosestElements(arr, k, x).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var n = arr.Length;
            if (n == k)
                return arr;
            var l = 0;
            var r = n - 1;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (arr[mid] >= x)
                    r = mid;
                else
                    l = mid + 1;
            }

            if (arr[l] > x)
                l--;
            r = l + 1;
            var result = new int[k];
            for (int i = 0; i < k; ++i)
            {
                if (r >= n)
                    l--;
                else if (l < 0)
                    r++;
                else
                {
                    if (Math.Abs(arr[l] - x) > Math.Abs(arr[r] - x))
                        r++;
                    else
                        l--;
                }
            }
            for (int i = 1; i <= k; ++i)
                result[i - 1] = arr[l + i];

            return result;
        }
    }
}
