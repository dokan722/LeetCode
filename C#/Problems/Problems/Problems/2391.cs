using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2391 : IProblem
    {
        public bool Test()
        {
            var garbage = new[] { "G", "P", "GP", "GG" };
            var travel = new[] { 2, 4, 3 };

            var expected = 21;

            var result = GarbageCollection(garbage, travel);

            Console.WriteLine(result);

            return result == expected;
        }

        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var n = garbage.Length;
            var p = 0;
            var g = 0;
            var m = 0;
            var cur = 0;
            var coll = garbage[0].Length;
            for (int i = 1; i < n; ++i)
            {
                coll += garbage[i].Length;
                cur += travel[i - 1];
                foreach (var c in garbage[i])
                {
                    if (c == 'G')
                        g = cur;
                    else if (c == 'P')
                        p = cur;
                    else
                        m = cur;
                }
            }

            return p + g + m + coll;
        }
    }
}
