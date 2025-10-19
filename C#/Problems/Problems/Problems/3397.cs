using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3397 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 2, 3, 3, 4 };
            var k = 2;

            var expected = 6;

            var result = MaxDistinctElements(nums, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxDistinctElements(int[] nums, int k)
        {
            Array.Sort(nums);
            int prev = int.MinValue;
            int result = 0;
            foreach (int num in nums)
            {
                int curr = Math.Min(Math.Max(num - k, prev + 1), num + k);
                if (curr > prev)
                {
                    result++;
                    prev = curr;
                }
            }
            return result;
        }
    }
}
