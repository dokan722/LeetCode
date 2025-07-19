using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _525 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {0, 1, 1, 1, 1, 1, 0, 0, 0};
            var expected = 6;

            var result = FindMaxLength(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int FindMaxLength(int[] nums)
        {
            var ids = new Dictionary<int, int>();
            ids[0] = -1;
            var runningSum = 0;
            var result = 0;
            for (int i  = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 0)
                    runningSum -= 1;
                else
                    runningSum += 1;
                if (ids.TryGetValue(runningSum, out var id))
                {
                    var length = i - id;
                    if (length > result)
                        result = length;
                }
                else
                    ids[runningSum] = i;
            }

            return result;
        }
    }
}
