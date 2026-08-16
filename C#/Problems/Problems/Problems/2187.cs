using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2187 : IProblem
    {
        public bool Test()
        {
            var time = new[] { 1, 2, 3 };
            var totalTrips = 5;

            var expected = 3;

            var result = MinimumTime(time, totalTrips);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumTime(int[] time, int totalTrips)
        {
            long left = 1;
            long right = (long)time[0] * totalTrips;
            while (left < right)
            {
                var mid = (left + right) / 2;
                long total = 0;
                foreach (var t in time)
                    total += mid / t;
                if (total >= totalTrips)
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }
    }
}
