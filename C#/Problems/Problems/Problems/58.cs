using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _58 : IProblem
    {
        public bool Test()
        {
            var s = "   fly me   to   the moon  ";

            var expected = 4;

            var result = LengthOfLastWord(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LengthOfLastWord(string s)
        {
            var end = s.Length - 1;
            while (end == ' ')
                end--;
            var begin = end;
            while (begin >= 0 && s[begin] != ' ')
                begin--;
            return end - begin;
        }
    }
}
