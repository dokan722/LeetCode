using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1539 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 3, 4, 7, 11 };
            var k = 5;

            var expected = 9;

            var result = FindKthPositive(arr, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindKthPositive(int[] arr, int k)
        {
            var cur = k;
            foreach (var num in arr)
            {
                if (cur < num)
                    return cur;
                cur += 1;
            }

            return cur;
        }
    }
}
