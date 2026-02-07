using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1846 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 2, 1, 2, 1 };

            var expected = 2;

            var result = MaximumElementAfterDecrementingAndRearranging(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            var n = arr.Length;
            Array.Sort(arr);
            var th = 1;
            for (int i = 1; i < n; ++i)
                th = Math.Min(th + 1, arr[i]);
            return th;
        }
    }
}
