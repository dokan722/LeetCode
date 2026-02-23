using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1461 : IProblem
    {
        public bool Test()
        {
            var s = "00110110";
            var k = 2;

            var expected = true;

            var result = HasAllCodes(s, k);

            return expected == result;
        }

        public bool HasAllCodes(string s, int k)
        {
            var n = s.Length;
            var present = new HashSet<string>();
            for (int i = 0; i <= n - k; ++i)
            {
                present.Add(s.Substring(i, k));
            }

            return (1 << k) == present.Count;
        }
    }
}
