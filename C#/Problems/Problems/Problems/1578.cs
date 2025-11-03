using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1578 : IProblem
    {
        public bool Test()
        {
            var colors = "abaac";

            var neededTime = new[] { 1, 2, 3, 4, 5 };

            var expected = 3;

            var result = MinCost(colors, neededTime);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinCost(string colors, int[] neededTime)
        {
            var n = colors.Length;
            var sum = neededTime[0];
            var maxTime = neededTime[0];
            var result = 0;
            for (int i = 1; i < n; ++i)
            {
                if (colors[i] != colors[i - 1])
                {
                    if (sum != maxTime)
                        result += sum - maxTime;
                    sum = neededTime[i];
                    maxTime = neededTime[i];
                }
                else
                {
                    sum += neededTime[i];
                    maxTime = Math.Max(maxTime, neededTime[i]);
                }
            }
            if (sum != maxTime)
                result += sum - maxTime;
            return result;
        }
    }
}
