using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1957 : IProblem
    {
        public bool Test()
        {
            var s = "leeetcode";

            var expected = "leetcode";

            var result = MakeFancyString(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string MakeFancyString(string s)
        {
            var result = new StringBuilder();
            result.Append(s[0]);

            var count = 1;
            for (int i = 1; i < s.Length; ++i)
            {
                if (s[i] == s[i - 1])
                    count++;
                else
                    count = 1;
                if (count < 3)
                    result.Append(s[i]);

            }

            return result.ToString();
        }
    }
}
