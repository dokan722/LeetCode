using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _796 : IProblem
    {
        public bool Test()
        {
            var s = "abcde";
            var goal = "cdeab";

            var expected = true;

            var result = RotateString(s, goal);

            Console.WriteLine(result);

            return expected == result;
        }

        public bool RotateString(string s, string goal)
        {
            var n = s.Length;
            if (n != goal.Length)
                return false;
            for (int i = 0; i < n; ++i)
            {
                var match = true;
                for (int j = 0; j < n; ++j)
                {
                    if (goal[j] != s[(i + j) % n])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    return true;
            }

            return false;
        }
    }
}
