using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _80 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1, 2, 2, 3 };

            var expected = 5;

            var result = RemoveDuplicates(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RemoveDuplicates(int[] nums)
        {
            var cur = 0;
            var cnt = 0;
            var prev = nums[0];
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == prev)
                    cnt++;
                else
                {
                    prev = nums[i];
                    cnt = 1;
                }
                if (cnt <= 2)
                {
                    nums[cur] = nums[i];
                    cur++;
                }
            }

            return cur;
        }
    }
}
