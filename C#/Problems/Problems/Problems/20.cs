using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _20 : IProblem
    {
        public bool Test()
        {
            var s = "()[]{}";

            var expected = true;

            var result = IsValid(s);

            return result == expected;
        }

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                else
                {
                    if (!stack.Any())
                        return false;
                    if (c == ')' && stack.Peek() != '(')
                        return false;
                    if (c == ']' && stack.Peek() != '[')
                        return false;
                    if (c == '}' && stack.Peek() != '{')
                        return false;
                    stack.Pop();
                }
            }

            return true && !stack.Any();
        }
    }
}
