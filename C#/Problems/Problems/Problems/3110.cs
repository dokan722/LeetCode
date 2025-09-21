using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3110 : IProblem
    {
        public bool Test()
        {
            var s = "hello";

            var expected = 13;

            var result = ScoreOfString(s);

            Console.WriteLine(result);

            return expected == result;
        }
        public int ScoreOfString(string s)
        {
            var n = s.Length;
            var result = 0;
            for(var i = 1; i < n; ++i)
                result += Math.Abs(s[i] - s[i - 1]);

            return result;
        }
    }
}
