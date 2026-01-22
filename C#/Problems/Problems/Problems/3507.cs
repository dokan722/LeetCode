using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3507 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 2, 3, 1 };

            var expected = 2;

            var result = MinimumPairRemoval(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinimumPairRemoval(int[] nums)
        {
            var list = nums.ToList();
            int minId = 0;
            var result = 0;
            var sorted = false;
            while (!sorted)
            {
                minId = -1;
                var minSum = int.MaxValue;
                sorted = true;
                for (int i = 0; i < list.Count - 1; ++i)
                {
                    if (list[i] > list[i + 1])
                    {
                        sorted = false;
                    }
                    var curSum = list[i] + list[i + 1];
                    if (curSum < minSum)
                    {
                        minId = i;
                        minSum = curSum;
                    }
                }
                if (!sorted)
                {
                    list[minId] = minSum;
                    list.RemoveAt(minId + 1);
                    result++;
                }
            }

            return result;
        }
    }
}
