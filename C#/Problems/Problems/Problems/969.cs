using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _969 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 3, 2, 4, 1 };

            var expected = new[] { 3, 4, 2, 3, 1, 2 };

            var result = PancakeSort(arr).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<int> PancakeSort(int[] arr)
        {
            var n = arr.Length;
            var result = new List<int>();
            for (int i = 1; i < n; ++i)
            {
                var mi = 0;
                for (int j = 1; j <= n - i; ++j)
                {
                    if (arr[j] > arr[mi])
                        mi = j;
                }
                if (mi == n - i)
                    continue;
                Flip(mi, arr);
                result.Add(mi + 1);
                Flip(n - i, arr);
                result.Add(n - i + 1);
            }

            return result;
        }

        private void Flip(int k, int[] arr)
        {
            for (int i = 0; i <= k / 2; ++i)
            {
                var tmp = arr[i];
                arr[i] = arr[k - i];
                arr[k - i] = tmp;
            }
        }
    }
}
