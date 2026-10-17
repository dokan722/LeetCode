using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3551 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 18, 43, 34, 16 };

            var expected = 2;

            var result = MinSwaps(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSwaps(int[] nums)
        {
            var n = nums.Length;
            var order = Enumerable.Range(0, n).ToArray();
            var sums = new int[n];
            for (int i = 0; i < n; ++i)
            {
                var num = nums[i];
                var s = 0;
                while (num > 0)
                {
                    s += num % 10;
                    num /= 10;
                }
                sums[i] = s;
            }
            var curPos = order.ToDictionary(x => x, x => x);
            var curOrder = order.ToArray();
            Array.Sort(order, Comparer<int>.Create((x, y) => (sums[x].CompareTo(sums[y]) == 0 ? nums[x].CompareTo(nums[y]) : sums[x].CompareTo(sums[y]))));
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (curOrder[i] != order[i])
                {
                    result++;

                    (curOrder[i], curOrder[curPos[order[i]]]) = (curOrder[curPos[order[i]]], curOrder[i]);
                    curPos[curOrder[curPos[order[i]]]] = curPos[curOrder[i]];
                    curPos[curOrder[i]] = i;
                }
            }
            return result;
        }
    }
}
