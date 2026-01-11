using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3184 : IProblem
    {
        public bool Test()
        {
            var hours = new[] { 12, 12, 30, 24, 24 };

            var expected = 2;

            var result = CountCompleteDayPairs(hours);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountCompleteDayPairs(int[] hours)
        {
            var rests = new int[24];
            var result = 0;
            foreach (var hour in hours)
            {
                var rem = hour % 24;
                var missing = (24 - rem) % 24;
                result += rests[missing];
                rests[rem]++;
            }

            return result;
        }
    }
}
