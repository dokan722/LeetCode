using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _826 : IProblem
    {
        public bool Test()
        {
            var difficulty = new[] {2, 4, 6, 8, 10};
            var profit = new[] {10, 20, 30, 40, 50};
            var worker = new[] { 4, 5, 6, 7 };

            var expected = 100;

            var result = MaxProfitAssignment(difficulty, profit, worker);

            Console.WriteLine(result);

            return result == expected;
        }


        // binary search
        public int MaxProfitAssignmentBS(int[] difficulty, int[] profit, int[] worker)
        {
            var n = difficulty.Length;
            var m = worker.Length;
            Array.Sort(difficulty, profit);
            var maxProfit = new int[n];
            var curr = profit[0];

            for (int i = 0; i < n; ++i)
            {
                curr = Math.Max(profit[i], curr);
                maxProfit[i] = curr;
            }

            var result = 0;
            foreach (var w in worker)
            {
                var l = -1;
                var r = n - 1;
                while (l < r)
                {
                    var mid = (l + r + 1) / 2;
                    if (difficulty[mid] <= w)
                        l = mid;
                    else
                        r = mid - 1;
                }
                if (l != -1)
                    result += maxProfit[l];
            }

            return result;
        }

        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            var n = difficulty.Length;
            var m = worker.Length;
            var maxSkill = 0;
            for (int i = 0; i < m; ++i)
                maxSkill = Math.Max(maxSkill, worker[i]);
            var bestJobs = new int[maxSkill + 1];
            for (int i = 0; i < n; ++i)
            {
                if (difficulty[i] <= maxSkill)
                    bestJobs[difficulty[i]] = Math.Max(bestJobs[difficulty[i]], profit[i]);
            }
            var curr = 0;
            for (int i = 0; i <= maxSkill; ++i)
            {
                curr = Math.Max(curr, bestJobs[i]);
                bestJobs[i] = curr;
            }
            var result = 0;
            for (int i = 0; i < m; ++i)
                result += bestJobs[worker[i]];

            return result;
        }
    }
}
