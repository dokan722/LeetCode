using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3561 : IProblem
    {
        public bool Test()
        {
            var s = "zadb";

            var expected = "db";

            var result = ResultingString(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ResultingString(string s)
        {
            var chars = new Stack<char>();
            foreach (char c in s)
            {
                if (chars.TryPeek(out var top))
                {
                    var diff = (top - c + 26) % 26;
                    if (diff == 1 || diff == 25)
                        chars.Pop();
                    else
                        chars.Push(c);
                }
                else
                    chars.Push(c);
            }

            var result = new List<char>(chars.Count);
            while (chars.TryPop(out var c))
                result.Add(c);

            result.Reverse();
            return new string(result.ToArray());
        }
    }
}
