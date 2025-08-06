using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _645 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 2, 4 };

            var expected = new[] { 2, 3 };

            var result = FindErrorNums(nums);

            return result.SequenceEqual(expected);
        }

        public int[] FindErrorNums(int[] nums)
        {
            var n = nums.Length;
            var presence = new bool[n];
            var result = new int[2];
            foreach (var num in nums)
            {
                if (presence[num - 1])
                    result[0] = num;
                presence[num - 1] = true;
            }

            for (int i = 0; i < n; i++)
            {
                if (!presence[i])
                {
                    result[1] = i + 1;
                    break;
                }
            }


            return result;
        }
    }
}
