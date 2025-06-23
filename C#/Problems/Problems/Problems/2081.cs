using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2081 : IProblem
    {
        public bool Test()
        {
            var k = 3;
            var n = 7;

            var expected = 499;

            var result = KMirror(k, n);

            Console.WriteLine(result);

            return result == expected;
        }

        public long KMirror(long k, long n)
        {
            var found = 0;
            var len = 1;
            long result = 0;
            while (found < n)
            {
                if (len % 2 == 0)
                {
                    var half = len / 2;
                    var start = (long)Math.Pow(10, half - 1);
                    var end = start * 10;
                    for (long i = start; i < end && found < n; i++)
                    {
                        var numS = $"{i}{string.Join("", i.ToString().ToCharArray().Reverse())}";
                        var num = long.Parse(numS);
                        if (IsPalindrome(numS) && IsPalindrome(ConvertToBaseReversed(num, k)))
                        {
                            found++;
                            result += num;
                        }
                    }
                }
                else
                {
                    var half = (len + 1) / 2;
                    var start = (long)Math.Pow(10, half - 1);
                    var end = start * 10;
                    for (long i = start; i < end && found < n; i++)
                    {
                        var numS = $"{i}{string.Join("", i.ToString().ToCharArray().SkipLast(1).Reverse())}";
                        var num = long.Parse(numS);
                        if (IsPalindrome(numS) && IsPalindrome(ConvertToBaseReversed(num, k)))
                        {
                            found++;
                            result += num;
                        }
                    }
                }

                len++;
            }

            return result;
        }

        private bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; ++i)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }

            return true;
        }

        private string ConvertToBaseReversed(long n, long b)
        {
            var result = new StringBuilder();
            while (n > 0)
            {
                var next = n % b;
                result.Append(next);
                n = n / b;
            }

            return result.ToString();
        }
    }
}
