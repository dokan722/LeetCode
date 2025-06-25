using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _984 : IProblem
    {
        public bool Test()
        {
            var a = 4;
            var b = 1;

            var expected = "aabaa";

            var result = StrWithout3a3b(a, b);

            Console.WriteLine(result);

            return result == expected;
        }

        public string StrWithout3a3b(int a, int b)
        {
            var result = new StringBuilder();

            var domSymbol = a > b ? 'a' : 'b';
            var other = domSymbol == 'a' ? 'b' : 'a';
            var diff = Math.Abs(a - b);
            var rest = string.Empty;
            if (diff >= 2)
            {
                diff -= 2;
                rest = new string(domSymbol, 2);
            }
            for (int i = 0; i < Math.Min(a, b); i++)
            {
                if (diff > 0)
                {
                    result.Append(domSymbol);
                    diff--;
                }
                result.Append(domSymbol);
                result.Append(other);
            }

            result.Append(rest);

            return result.ToString();
        }
    }
}
