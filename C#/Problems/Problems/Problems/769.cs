using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _769 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 0, 2, 3, 4 };

            var expected = 4;

            var result = MaxChunksToSorted(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxChunksToSorted(int[] arr)
        {
            var n = arr.Length;
            var m = -1;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                m = Math.Max(arr[i], m);
                if (m == i)
                    result++;
            }

            return result;
        }
    }
}
