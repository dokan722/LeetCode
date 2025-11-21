using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _443 : IProblem
    {
        public bool Test()
        {
            var chars = new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

            var expected1 = 6;
            var expected2 = new[] { 'a', '2', 'b', '2', 'c', '3' };
            var result = Compress(chars);
            var charResult = chars.Take(result).ToArray();

            Console.WriteLine(result);
            Utils.Print1DArray(charResult);

            return result == expected1 && Utils.Compare1DArrays(charResult, expected2);
        }

        public int Compress(char[] chars)
        {
            var n = chars.Length;
            if (n < 2)
                return n;
            var j = 0;
            var start = 0;
            for (int i = 1; i < n; ++i)
            {
                if (chars[i] != chars[i - 1])
                {
                    var l = i - start;
                    chars[j] = chars[i - 1];
                    j++;
                    if (l > 1)
                    {
                        foreach (var digit in l.ToString())
                        {
                            chars[j] = digit;
                            j++;
                        }
                    }

                    start = i;
                }
            }
            var fl = (n - start);
            chars[j] = chars[n - 1];
            j++;
            if (fl > 1)
            {
                foreach (var digit in fl.ToString())
                {
                    chars[j] = digit;
                    j++;
                }
            }

            return j;
        }
    }
}
