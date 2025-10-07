using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1488 : IProblem
    {
        public bool Test()
        {
            var rains = new[] { 1, 2, 0, 0, 2, 1 };

            var expected = new[] { -1, -1, 2, 1, -1, -1 };

            var result = AvoidFlood(rains);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] AvoidFlood(int[] rains)
        {
            var n = rains.Length;
            var dry = new List<int>();
            var fullDays = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (rains[i] == 0)
                    dry.Add(i);
                else
                {
                    if (fullDays.TryGetValue(rains[i], out var day))
                    {
                        var emptyDay = -1;
                        for (int j = 0; j < dry.Count; ++j)
                        {
                            if (dry[j] > day)
                            {
                                emptyDay = j;
                                break;
                            }
                        }

                        if (emptyDay == -1)
                            return Array.Empty<int>();
                        rains[dry[emptyDay]] = rains[i];
                        dry.RemoveAt(emptyDay);
                    }

                    fullDays[rains[i]] = i;
                    rains[i] = -1;
                }
            }

            foreach (var d in dry)
                rains[d] = 1; 

            return rains;
        }
    }
}
