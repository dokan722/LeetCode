using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2554 : IProblem
    {
        public bool Test()
        {
            var banned = new[] { 1, 6, 5 };
            var n = 5;
            var maxSum = 6;

            var expected = 2;

            var result = MaxCount(banned, n, maxSum);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxCount(int[] banned, int n, int maxSum)
        {
            var result = 0;
            var cSum = 0;
            var bannedSet = banned.ToHashSet();
            for (int i = 1; i <= n; ++i)
            {
                if (cSum + i > maxSum)
                    break;
                if (bannedSet.Contains(i))
                    continue;

                cSum += i;
                result++;
            }

            return result;
        }
    }
}
