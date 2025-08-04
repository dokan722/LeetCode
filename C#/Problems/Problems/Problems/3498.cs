using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3498 : IProblem
    {
        public bool Test()
        {
            var  s = "abc";

            var expected = 148;

            var result = ReverseDegree(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ReverseDegree(string s)
        {
            var result = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                result += (26 - (s[i] - 'a')) * (i + 1);
            }

            return result;
        }
    }
}
