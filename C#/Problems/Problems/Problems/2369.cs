using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2369 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 4, 4, 4, 5, 6 };

            var expected = true;

            var result = ValidPartition(nums);

            return result == expected;
        }

        public bool ValidPartition(int[] nums)
        {
            var n = nums.Length;
            var check = new Stack<int>();
            var visited = new bool[n];
            check.Push(0);
            while (check.Count > 0)
            {
                var popped = check.Pop();
                if (visited[popped])
                    continue;
                if (CheckTwo(nums, popped))
                {
                    var ch = popped + 2;
                    if (ch == n)
                        return true;
                    check.Push(ch);
                }
                if (CheckThree(nums, popped))
                {
                    var ch = popped + 3;
                    if (ch == n)
                        return true;
                    check.Push(ch);
                }

                visited[popped] = true;
            }

            return false;
        }

        private bool CheckTwo(int[] nums, int index)
        {
            if (index + 1 >= nums.Length)
                return false;
            if (nums[index] == nums[index + 1])
                return true;

            return false;
        }

        private bool CheckThree(int[] nums, int index)
        {
            if (index + 2 >= nums.Length)
                return false;
            if (nums[index] == nums[index + 1] && nums[index + 1] == nums[index + 2])
                return true;
            if (nums[index] == nums[index + 1] - 1 && nums[index + 1] == nums[index + 2] - 1)
                return true;

            return false;
        }
    }
}
