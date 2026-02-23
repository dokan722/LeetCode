using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3185 : IProblem
    {
        public bool Test()
        {
            var hours = new[] { 12, 12, 30, 24, 24 };

            var expected = 2;

            var result = CountCompleteDayPairs(hours);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountCompleteDayPairs(int[] hours)
        {
            long result = 0;
            var counts = new Dictionary<int, int>();
            foreach (var hour in hours)
            {
                var rem = hour % 24;
                var req = (24 - rem) % 24;
                if (counts.ContainsKey(req))
                    result += counts[req];
                if (counts.ContainsKey(rem))
                    counts[rem]++;
                else
                    counts[rem] = 1;
            }

            return result;
        }
    }
}
