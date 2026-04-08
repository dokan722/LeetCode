using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1299 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 17, 18, 5, 4, 6, 1 };

            var expected = new[] { 18, 6, 6, 6, 1, -1 };

            var result = ReplaceElements(arr);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ReplaceElements(int[] arr)
        {
            var n = arr.Length;
            var mx = arr[n - 1];
            arr[n - 1] = -1;
            for (int i = n - 2; i >= 0; --i)
            {
                var tmp = arr[i];
                arr[i] = mx;
                mx = Math.Max(mx, tmp);
            }

            return arr;
        }
    }
}
