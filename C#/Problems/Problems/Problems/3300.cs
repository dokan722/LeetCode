using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3300 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 12, 13, 14 };

            var expected = 1;

            var result = MinElement(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinElement(int[] nums)
        {
            var result = int.MaxValue;
            foreach (var num in nums)
            {
                var n = num;
                var d = 0;
                while (n > 0)
                {
                    d += n % 10;
                    n /= 10;
                }

                result = Math.Min(result, d);
            }

            return result;
        }
    }
}
