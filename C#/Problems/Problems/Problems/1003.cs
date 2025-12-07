using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1003 : IProblem
    {
        public bool Test()
        {
            var s = "aabcbc";

            var expected = true;

            var result = IsValid(s);

            return expected == result;
        }

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == 'c')
                {
                    if (!(stack.Count > 1 && stack.Pop() == 'b' && stack.Pop() == 'a'))
                        return false;
                }
                else
                    stack.Push(c);
            }

            return stack.Count == 0;
        }
    }
}
