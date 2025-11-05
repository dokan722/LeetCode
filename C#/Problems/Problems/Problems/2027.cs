using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2027 : IProblem
    {
        public bool Test()
        {
            var s = "XXOX";

            var expected = 2;

            var result = MinimumMoves(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumMoves(string s)
        {
            var n = s.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == 'X')
                {
                    result++;
                    i += 2;
                }
            }
            return result;
        }
    }
}
