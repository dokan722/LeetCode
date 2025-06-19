using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2294 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 6, 1, 2, 5 };

            var k = 2;

            var expected = 2;

            var result = PartitionArray(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var cnt = 0;
            var prev = nums[0];
            var result = 0;
            var addLast = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != prev)
                {
                    addLast = false;
                    cnt += nums[i] - prev;
                    prev = nums[i];
                    if (cnt > k)
                    {
                        cnt = 0;
                        result++;
                        addLast = true;
                    }
                }
            }

            if (cnt != 0 || addLast)
                result++;

            return result;
        }
    }
}
