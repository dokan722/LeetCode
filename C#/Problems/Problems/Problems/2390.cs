using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2390 : IProblem
    {
        public bool Test()
        {
            var s = "leet**cod*e";

            var expected = "lecoe";

            var result = RemoveStars(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '*')
                    stack.Pop();
                else
                    stack.Push(c);
            }

            return string.Join("", stack.Reverse());
        }
    }
}
