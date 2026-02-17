using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1186 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, -2, -2, 3 };

            var expected = 3;

            var result = MaximumSum(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumSum(int[] arr)
        {
            var n = arr.Length;
            var all = arr[0];
            var delete = arr[0];
            var result = arr[0];
            for (int i = 1; i < n; ++i)
            {
                delete = Math.Max(all, delete + arr[i]);
                all = Math.Max(all + arr[i], arr[i]);
                result = Math.Max(result, Math.Max(all, delete));
            }

            return result;
        }
    }
}
