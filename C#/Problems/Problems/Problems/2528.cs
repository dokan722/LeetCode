using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2528 : IProblem
    {
        public bool Test()
        {
            var stations = new[] { 4, 2 };
            var r = 1;
            var k = 1;

            var expected = 7;

            var result = MaxPower(stations, r, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxPower(int[] stations, int r, int k)
        {
            var n = stations.Length;
            long l = int.MaxValue;
            long h = int.MinValue;
            var diff = new long[n];
            for (int i = 0; i < n; i++)
            {
                var station = stations[i];
                l = Math.Min(l, station);
                if (i >= r)
                    diff[i - r] += station;
                else
                    diff[0] += station;
                if (i + r + 1 < n)
                    diff[i + r + 1] -= station;
            }

            long currStations = 0;
            for (int i = 0; i < n; ++i)
            {
                currStations += diff[i];
                h = Math.Max(h, currStations);
            }

            h += k;
            while (l < h)
            {
                var m = (l + h + 1) / 2;
                var ranges = new long[n];
                var poss = true;
                long preSum = 0;
                long rem = k;
                for (int i = 0; i < n; ++i)
                {
                    preSum += diff[i];
                    preSum += ranges[i];
                    if (preSum < m)
                    {
                        var newStations = m - preSum;
                        rem -= newStations;
                        preSum += newStations;
                        if (i + 2 * r + 1 < n)
                            ranges[i + 2 * r + 1] -= newStations;
                    }

                    if (rem < 0)
                    {
                        poss = false;
                        break;
                    }
                }

                if (poss)
                    l = m;
                else
                    h = m - 1;
            }

            return l;
        }
    }
}
