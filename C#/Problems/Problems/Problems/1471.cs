using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1471 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 6, 7, 11, 7, 6, 8 };
            var k = 5;

            var expected = new[] { 11, 8, 6, 6, 7 };

            var result = GetStrongest(arr, k);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GetStrongest(int[] arr, int k)
        {
            var n = arr.Length;
            if (k == n)
                return arr;
            Array.Sort(arr);
            var result = new int[k];
            var m = arr[(n - 1) / 2];
            var left = 0;
            var right = n - 1;
            for (int i = 0; i < k; ++i)
            {
                if (Math.Abs(m - arr[left]) > Math.Abs(m - arr[right]))
                {
                    result[i] = arr[left];
                    left++;
                }
                else
                {
                    result[i] = arr[right];
                    right--;
                }
            }

            return result;
        }
    }
}
