using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2433 : IProblem
    {
        public bool Test()
        {
            var pref = new[] { 5, 2, 0, 3, 1 };

            var expected = new[] { 5, 7, 2, 3, 2 };

            var result = FindArray(pref);

            return result.SequenceEqual(expected);
        }

        public int[] FindArray(int[] pref)
        {
            var prev = pref[0];
            for (int i = 1; i < pref.Length; i++)
            {
                var tmp = pref[i];
                pref[i] = prev ^ pref[i];
                prev = tmp;
            }

            return pref;
        }
    }
}
