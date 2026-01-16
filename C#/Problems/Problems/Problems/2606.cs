using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2606 : IProblem
    {
        public bool Test()
        {
            var s = "adaa";
            var chars = "d";
            var vals = new[] { -1000 };

            var expected = 2;

            var result = MaximumCostSubstring(s, chars, vals);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumCostSubstring(string s, string chars, int[] vals)
        {
            var n = s.Length;
            var m = chars.Length;
            var costs = new int[26];
            for (int i = 0; i < 26; ++i)
                costs[i] = i + 1;
            for (int i = 0; i < m; ++i)
                costs[chars[i] - 'a'] = vals[i]; 
            
            var result = 0;
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                curr += costs[s[i] - 'a'];
                result = Math.Max(curr, result);
                if (curr < 0)
                    curr = 0;
            }

            return result;
        }
    }
}
