using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems.Problems
{
    public class _3440 : IProblem
    {
        public bool Test()
        {
            var eventTime = 10;
            var startTime = new int[] { 0, 3, 7, 9 };
            var endTime = new int[] { 1, 4, 8, 10 };

            var expected = 6;
            var result = MaxFreeTime(eventTime, startTime, endTime);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
        {
            var n = startTime.Length;
            var nGaps = n + 1;
            var sum = 0;
            var gaps = new int[nGaps];
            for (int i = 0; i < nGaps; ++i)
                gaps[i] = GetGapLength(i, startTime, endTime, eventTime);
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int gap in gaps)
            {
                if (gap > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = gap;
                }
                else if (gap > max2)
                {
                    max3 = max2;
                    max2 = gap;
                }
                else if (gap > max3)
                {
                    max3 = gap;
                }
            }
            
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var maxGap = max1;
                if (Math.Max(gaps[i], gaps[i + 1]) == max1)
                {
                    if (Math.Min(gaps[i], gaps[i + 1]) == max2)
                        maxGap = max3;
                    else
                        maxGap = max2;
                }
                var currEvent = endTime[i] - startTime[i];
                var freeTime = currEvent <= maxGap ? gaps[i] + gaps[i + 1] + currEvent : gaps[i] + gaps[i + 1];
                if (freeTime > result)
                    result = freeTime;
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