using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2042 : IProblem
    {
        public bool Test()
        {
            var s = "1 box has 3 blue 4 red 6 green and 12 yellow marbles";

            var expected = true;

            var result = AreNumbersAscending(s);

            return expected == result;
        }

        public bool AreNumbersAscending(string s)
        {
            var n = s.Length;
            var prev = -1;

            for (int i = 0; i < n; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    var end = i;
                    while (end < n && char.IsDigit(s[end]))
                        end++;
                    var num = int.Parse(s.Substring(i, end - i));
                    if (num <= prev)
                        return false;

                    i = end;
                    prev = num;
                }
            }

            return true;
        }
    }
}
