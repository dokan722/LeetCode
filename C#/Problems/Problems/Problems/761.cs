using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _761 : IProblem
    {
        public bool Test()
        {
            var s = "11011000";

            var expected = "11100100";

            var result = MakeLargestSpecial(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string MakeLargestSpecial(string s)
        {
            var n = s.Length;
            var result = new List<string>();

            var level = 0;
            var last = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '0')
                    level--;
                else
                    level++;
                if (level == 0)
                {
                    result.Add("1" + MakeLargestSpecial(s.Substring(last + 1, i - last - 1)) + "0");
                    last = i + 1;
                }
            }

            return string.Join("", result.OrderByDescending(x => x));
        }
    }
}
