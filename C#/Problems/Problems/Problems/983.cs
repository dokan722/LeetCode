using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _983 : IProblem
    {
        public bool Test()
        {
            var days = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
            var costs = new[] { 2, 7, 15 };

            var expected = 17;

            var result = MincostTickets(days, costs);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MincostTickets(int[] days, int[] costs)
        {
            var maxDay = days[^1];
            var dailyCosts = new int[maxDay + 1];
            var nextTravel = 0;
            var prevDay = 0;
            for (int i = 1; i <= maxDay; i++)
            {
                if (i == days[nextTravel])
                {
                    dailyCosts[i] =
                        Math.Min(Math.Min(dailyCosts[i - 1] + costs[0], dailyCosts[Math.Max(0, i - 7)] + costs[1]),
                            dailyCosts[Math.Max(0, i - 30)] + costs[2]);
                    prevDay = dailyCosts[i];
                    nextTravel++;
                }
                else
                {
                    dailyCosts[i] = prevDay;
                }
            }

            return dailyCosts[maxDay];
        }
    }
}
