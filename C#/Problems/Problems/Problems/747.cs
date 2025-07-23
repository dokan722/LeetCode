using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _747 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 6, 1, 0 };

            var expected = 1;

            var result = DominantIndex(nums);

            Console.WriteLine(result);

            return expected == result;

        }

        public int DominantIndex(int[] nums)
        {
            var max = nums[0] > nums[1] ? 0 : 1;
            var almostMax = nums[0] > nums[1] ? 1 : 0;

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] > nums[max])
                {
                    almostMax = max;
                    max = i;
                }
                else if (nums[i] > nums[almostMax])
                {
                    almostMax = i;
                }
            }

            if (nums[max] >= 2 * nums[almostMax])
                return max;
            return -1;
        }
    }
}
