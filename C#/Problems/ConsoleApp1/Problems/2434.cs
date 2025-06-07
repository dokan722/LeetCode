using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    internal class _2434 : IProblem
    {
        public bool Test()
        {
            var s = "mmuqezwmomeplrtskz";

            var expected = "eekstrlpmomwzqummz";

            var result = RobotWithString(s);

            Console.Write(result);

            return expected == result;
        }

        public string RobotWithString(string s)
        {
            var t = new StringBuilder();
            var result = new StringBuilder();
            

            while (s.Length > 0)
            {
                var minLetter = s.Min();
                while (t.Length > 0 && t[t.Length - 1] <= minLetter)
                {
                    result.Append(t[t.Length - 1]);
                    t.Remove(t.Length - 1, 1);
                }
                var numLetters = 0;
                var max = -1;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == minLetter)
                    {
                        t.Append(s.Substring(max + 1, int.Max(i - max - 1, 0)));
                        max = i;
                        numLetters++;
                    }
                }
                s = s.Substring(max + 1, s.Length - max - 1);
                result.Append(new string(minLetter, numLetters));
            }
            result.Append(new string(t.ToString().Reverse().ToArray()));

            return result.ToString();
        }
    }
}
