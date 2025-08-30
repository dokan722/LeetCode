using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // SAME AS 1081
    public class _316 : IProblem
    {
        public bool Test()
        {
            var s = "bcabc";

            var expected = "abc";

            var result = RemoveDuplicateLetters(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string RemoveDuplicateLetters(string s)
        {
            var n = s.Length;
            var indices = Enumerable.Repeat(int.MaxValue, 26).ToArray();
            for (int i = 0; i < n; ++i)
                indices[s[i] - 'a'] = i;
            var stack = new Stack<char>();
            var inStack = new bool[26];

            for (int i = 0; i < n; ++i)
            {
                if (inStack[s[i] - 'a'])
                    continue;

                while (stack.Any() && stack.Peek() > s[i] && i < indices[stack.Peek() - 'a'])
                {
                    inStack[stack.Peek() - 'a'] = false;
                    stack.Pop();
                }

                inStack[s[i] - 'a'] = true;
                stack.Push(s[i]);
            }

            var result = new StringBuilder();
            while (stack.Any())
                result.Insert(0, stack.Pop());

            return result.ToString();
        }
    }
}
