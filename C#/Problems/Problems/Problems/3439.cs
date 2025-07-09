using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3439 : IProblem
    {
        public bool Test()
        {
            var eventTime = 99;
            var k = 1;
            var startTime = new int[] { 7, 21, 25 };
            var endTime = new int[] { 13, 25, 78 };

            var expected = 21;
            var result = MaxFreeTime(eventTime, k, startTime, endTime);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
        {
            var n = startTime.Length;
            var gaps = n + 1;
            var sum = 0;
            for (int i = 0; i <= k && i < gaps; ++i)
                sum += GetGapLength(i, startTime, endTime, eventTime);
            if (k >= n)
                return sum;
            var result = sum;
            for (int i = 0; i < gaps - k - 1; ++i)
            {
                sum -= GetGapLength(i, startTime, endTime, eventTime);
                sum += GetGapLength(i + k + 1, startTime, endTime, eventTime);
                if (sum > result)
                    result = sum;
            }

            return result;
        }

        private int GetGapLength(int i, int[] startTime, int[] endTime, int eventTime)
        {
            if (i == 0)
                return startTime[0];
            if (i == startTime.Length)
                return eventTime - endTime[^1];

            return startTime[i] - endTime[i - 1];
        }
    }
}
