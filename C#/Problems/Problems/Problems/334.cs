using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _334 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };

            var expected = true;

            var result = IncreasingTriplet(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public bool IncreasingTriplet(int[] nums)
        {
            var first = int.MaxValue;
            var second = int.MaxValue;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] <= first)
                    first = nums[i];
                else if (nums[i] <= second)
                    second = nums[i];
                else
                    return true;
            }

            return false;
        }
    }
}
