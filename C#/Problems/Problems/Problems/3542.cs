using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3542 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 1, 2, 1 };

            var expected = 3;

            var result = MinOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums)
        {
            var stack = new Stack<int>();
            var result = 0;
            foreach (var num in nums)
            {
                while (stack.TryPeek(out var top) && top >= num)
                {
                    stack.Pop();
                    if (top != num)
                        result++;
                }
                stack.Push(num);
            }

            while (stack.TryPop(out var top))
            {
                if (top != 0)
                    result++;
            }

            return result;
        }
    }
}
