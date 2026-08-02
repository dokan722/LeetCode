using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3849 : IProblem
    {
        public bool Test()
        {
            var s = "101";
            var t = "011";

            var expected = "110";

            var result = MaximumXor(s, t);

            Console.WriteLine(result);

            return result == expected;
        }

        public string MaximumXor(string s, string t)
        {
            var n = s.Length;
            var ones = 0;
            foreach (var c in t)
                if (c == '1')
                    ones++;
            var zeros = n - ones;
            var result = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '0')
                {
                    if (ones > 0)
                    {
                        result.Append('1');
                        ones--;
                    }
                    else
                    {
                        result.Append('0');
                        zeros--;
                    }
                }
                else
                {
                    if (zeros > 0)
                    {
                        result.Append('1');
                        zeros--;
                    }
                    else
                    {
                        result.Append('0');
                        ones--;
                    }
                }
            }

            return result.ToString();
        }
    }
}
