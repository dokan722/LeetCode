using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1190 : IProblem
    {
        public bool Test()
        {
            var s = "(ed(et(oc))el)";

            var expected = "leetcode";

            var result = ReverseParentheses(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string ReverseParentheses(string s)
        {
            var n = s.Length;
            var strings = new Stack<string>();
            var id = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    strings.Push(s.Substring(id, i - id));
                    strings.Push("(");
                    id = i + 1;
                }
                else if (s[i] == ')')
                {
                    var reversed = string.Join("", s.Substring(id, i - id).Reverse());
                    while (strings.TryPeek(out var top) && top != "(")
                        reversed += string.Join("", strings.Pop().Reverse());
                    strings.Pop();
                    strings.Push(reversed);
                    id = i + 1;
                }
            }

            var result = new StringBuilder();
            while (strings.TryPop(out var top))
                result.Insert(0, top);
            if (id < n)
                result.Append(s.Substring(id));
            return result.ToString();
        }
    }
}
