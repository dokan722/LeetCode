using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1562 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 5, 1, 2, 4 };

            var m = 1;

            var expected = 4;

            var result = FindLatestStep(nums, m);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindLatestStep(int[] arr, int m)
        {
            var groups = new int[arr.Length + 2];
            var result = -1;
            var count = 0;
            for (int i = 1; i < arr.Length + 1; i++)
            {
                var index = arr[i - 1];
                var left = groups[index - 1];
                var right = groups[index + 1];
                var length = left + right + 1;
                groups[index - left] = length;
                groups[index + right] = length;
                if (left == m)
                    count--;
                if (right == m)
                    count--;
                if (length == m)
                    count++;
                if (count > 0)
                    result = i;
            }

            return result;
        }
    }
}
