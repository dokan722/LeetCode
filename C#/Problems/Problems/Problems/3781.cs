using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3781 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 5, 2, 3 };
            var s = "01010";

            var expected = 7;

            var result = MaximumScore(nums, s);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumScore(int[] nums, string s)
        {
            var n = nums.Length;
            var queue = new PriorityQueue<int, int>();
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                queue.Enqueue(nums[i], -nums[i]);
                if (s[i] == '1')
                {
                    result += queue.Dequeue();
                }
            }
            return result;
        }
    }
}
