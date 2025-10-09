using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3494 : IProblem
    {
        public bool Test()
        {
            var skill = new[] { 1, 5, 2, 4 };
            var mana = new[] { 5, 1, 4, 2 };

            var expected = 110;

            var result = MinTime(skill, mana);

            Console.WriteLine(result);

            return expected == result;
        }
        public long MinTime(int[] skill, int[] mana)
        {
            var n = skill.Length;
            var m = mana.Length;
            var times = new long[n + 1];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 1; j <= n; j++)
                    times[j] = Math.Max(times[j], times[j - 1]) + (long)mana[i] * skill[j - 1];

                for (int j = n - 1; j >= 0; j--)
                    times[j] = times[j + 1] - (long)mana[i] * skill[j];
            }
            return times[n];
        }
    }
}
