using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2300 : IProblem
    {
        public bool Test()
        {
            var spells = new[] { 5, 1, 3 };
            var potions = new[] { 1, 2, 3, 4, 5 };
            var success = 7;

            var expected = new int[] { 4, 0, 3 };

            var result = SuccessfulPairs(spells, potions, success);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var n = spells.Length;
            var m = potions.Length;
            Array.Sort(potions);
            var result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                var req = (success + spells[i] - 1) / spells[i];
                if (potions[0] >= req)
                    result[i] = m;
                else if (potions[m - 1] < req)
                    result[i] = 0;
                else
                {
                    var left = 0;
                    var right = m - 1;
                    while (left < right)
                    {
                        var mid = (left + right + 1) / 2;
                        if (potions[mid] >= req)
                            right = mid - 1;
                        else
                            left = mid;
                    }

                    result[i] = m - left - 1;
                }
            }

            return result;
        }
    }
}
