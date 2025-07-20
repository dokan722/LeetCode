using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _825 : IProblem
    {
        public bool Test()
        {
            var ages = new[] { 20, 30, 100, 110, 120 };
            var expected = 3;

            var result = NumFriendRequests(ages);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumFriendRequests(int[] ages)
        {
            var counts = new int[121];
            foreach (var age in ages)
            {
                counts[age]++;
            }

            var result = 0;
            for (var i = 1; i <= 120; ++i)
            {
                var x = 0.5 * i + 7;
                var minAge = (int)Math.Ceiling(x);
                var start = minAge == x ? minAge + 1 : minAge;
                var maxAge = i;
                for (int j = start; j < maxAge; ++j)
                    result += counts[j] * counts[i];
                if (i >= start)
                    result += Math.Max(counts[i] * (counts[i] - 1), 0);
            }

            return result;
        }
    }
}
