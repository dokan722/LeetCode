using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3452 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 2, 1, 5, 4 };
            var k = 2;

            var expected = 12;

            var result = SumOfGoodNumbers(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SumOfGoodNumbers(int[] nums, int k)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > GetNum(i + k, nums) && nums[i] > GetNum(i - k, nums))
                    result += nums[i];
            }

            return result;
        }

        private int GetNum(int id, int[] nums)
        {
            if  (id < 0 ||  id >= nums.Length)
                return -1;
            return nums[id];
        }
    }
}
