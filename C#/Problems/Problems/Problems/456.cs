using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _456 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };

            var expected = false;

            var result = Find132pattern(nums);

            return result == expected;
        }

        public bool Find132pattern(int[] nums)
        {
            var n = nums.Length;
            int two = int.MinValue;
            var stack = new Stack<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                if (nums[i] < two)
                    return true;
                while (stack.TryPeek(out var top)  && nums[i] > top)
                {
                    two = stack.Pop();
                }
                stack.Push(nums[i]);
            }

            return false;
        }
    }
}
