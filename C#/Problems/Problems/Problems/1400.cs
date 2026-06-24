using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1400 : IProblem
    {
        public bool Test()
        {
            var s = "annabelle";
            var k = 2;

            var expected = true;
            
            var result = CanConstruct(s, k);

            return result == expected;
        }

        public bool CanConstruct(string s, int k)
        {
            if (s.Length < k)
                return false;
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            var odd = 0;
            for (int i = 0; i < 26; ++i)
                if (counts[i] % 2 == 1)
                    odd++;
            return odd <= k;
        }
    }
}
