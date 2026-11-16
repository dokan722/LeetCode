using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2243 : IProblem
    {
        public bool Test()
        {
            var s = "11111222223";
            var k = 3;

            var expected = "135";

            var result = DigitSum(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public string DigitSum(string s, int k)
        {
            while (s.Length > k)
            {
                var groups = (s.Length + k - 1) / k;
                var next = "";
                for (int i = 0; i < groups; ++i)
                {
                    var cur = 0;
                    var sh = i * k;
                    var size = Math.Min(k, s.Length - sh);
                    for (int j = 0; j < size; ++j)
                        cur += s[sh + j] - '0';
                    next += cur.ToString();
                }
                s = next;
            }

            return s;
        }
    }
}
