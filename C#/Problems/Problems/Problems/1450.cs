using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1450 : IProblem
    {
        public bool Test()
        {
            var startTime = new[] { 1, 2, 3 };
            var endTime = new[] { 3, 2, 7 };
            var queryTime = 4;

            var expected = 1;

            var result = BusyStudent(startTime, endTime, queryTime);

            Console.WriteLine(result);

            return result == expected;
        }
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var n = startTime.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                    result++;
            }

            return result;
        }

    }
}
