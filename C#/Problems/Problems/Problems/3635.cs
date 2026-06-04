using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3635 : IProblem
    {
        public bool Test()
        {
            var landStartTime = new[] { 2, 8 };
            var landDuration = new[] { 4, 1 };
            var waterStartTime = new[] { 6 };
            var waterDuration = new[] { 3 };

            var expected = 9;

            var result = EarliestFinishTime(landStartTime, landDuration, waterStartTime, waterDuration);

            Console.WriteLine(result);

            return result == expected;
        }

        public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
        {
            var nl = landStartTime.Length;
            var nw = waterStartTime.Length;
            var li = 0;
            var wi = 0;
            for (int i = 1; i < nl; ++i)
            {
                if (landStartTime[i] + landDuration[i] < landStartTime[li] + landDuration[li])
                    li = i;
            }
            for (int i = 1; i < nw; ++i)
            {
                if (waterStartTime[i] + waterDuration[i] < waterStartTime[wi] + waterDuration[wi])
                    wi = i;
            }
            var lf = int.MaxValue;
            for (int i = 0; i < nw; ++i)
            {
                var end = Math.Max(landStartTime[li] + landDuration[li], waterStartTime[i]) + waterDuration[i];
                lf = Math.Min(lf, end);
            }
            var wf = int.MaxValue;
            for (int i = 0; i < nl; ++i)
            {
                var end = Math.Max(waterStartTime[wi] + waterDuration[wi], landStartTime[i]) + landDuration[i];
                wf = Math.Min(wf, end);
            }

            return Math.Min(lf, wf);
        }
    }
}
