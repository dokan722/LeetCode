using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _401 : IProblem
    {
        public bool Test()
        {
            var turnedOn = 9;

            var expected = new string[] { };

            var result = ReadBinaryWatch(turnedOn).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var result = new List<string>();
            var values = new int[] { 8, 4, 2, 1, 32, 16, 8, 4, 2, 1 };
            WatchRec(0, turnedOn, 0, 0, 0, values, result);
            return result;
        }

        private void WatchRec(int curr, int limit, int start, int minutes, int hours, int[] values, List<string> result)
        {
            if (minutes > 59 || hours > 11 || 10 - start < limit - curr)
                return;
            if (curr == limit)
            {
                result.Add(hours.ToString() + ":" + minutes.ToString("D2"));
                return;
            }
            for (int i = start; i < 4; ++i)
                WatchRec(curr + 1, limit, i + 1, minutes, hours + values[i], values, result);
            for (int i = Math.Max(start, 4); i < 10; ++i)
                WatchRec(curr + 1, limit, i + 1, minutes + values[i], hours, values, result);
        }
    }
}
