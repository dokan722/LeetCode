using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3936 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 0, 3, 12 };

            var expcted = 2;

            var result = MinimumSwaps(nums);

            Console.WriteLine(result);

            return result == expcted;
        }

        public int MinimumSwaps(int[] nums)
        {
            var n = nums.Length;
            var r = n - 1;
            var l = 0;
            var result = 0;
            while (l < r)
            {
                if (nums[r] == 0)
                    r--;
                else if (nums[l] == 0)
                {
                    result++;
                    l++;
                    r--;
                }
                else
                    l++;
            }

            return result;
        }
    }
}
