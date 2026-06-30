using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2734 : IProblem
    {
        public bool Test()
        {
            var s = "cbabc";

            var exected = "baabc";

            var result = SmallestString(s);

            Console.WriteLine(result);

            return result == exected;
        }

        public string SmallestString(string s)
        {
            var n = s.Length;
            var start = -1;
            var end = n;
            var map = new char[26];
            map[0] = 'z';
            for (int i = 1; i < 26; ++i)
                map[i] = (char)('a' + i - 1);
            for (int i = 0; i < n; ++i)
            {
                if (start == -1 && s[i] != 'a')
                    start = i;
                else if (start != -1 && s[i] == 'a')
                {
                    end = i;
                    break;
                }
            }
            if (start == -1)
                return new string('a', n - 1) + "z";
            var changed = new StringBuilder();
            for (int i = start; i < end; ++i)
                changed.Append(map[s[i] - 'a']);
            return s.Substring(0, start) + changed.ToString() + s.Substring(end);
        }
    }
}
