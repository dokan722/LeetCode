using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2138 : IProblem
    {
        public bool Test()
        {
            var s = "abcdefghi";
            var k = 3;
            var fill = 'x';

            var expected = new string[] { "abc", "def", "ghi" };

            var result = DivideString(s, k, fill);

            Console.WriteLine(string.Join(", ", result));

            return result.SequenceEqual(expected);
        }

        public string[] DivideString(string s, int k, char fill)
        {
            var size = (int)Math.Ceiling((double)s.Length / k);
            var result = new string[size];
            for (int i = 0; i < size - 1; i++)
            {
                result[i] = s.Substring(i * k, k);
            }

            var rest = s.Length - (size - 1) * k;
            if (rest > 0)
            {
                result[size - 1] = string.Concat(s.Substring(k * (size - 1), rest), new string(fill, k - rest));
            }

            return result;
        }
    }
}
