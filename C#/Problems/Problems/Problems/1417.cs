using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1417 : IProblem
    {
        public bool Test()
        {
            var s = "a0b1c2";

            var expected = "c2b1a0";

            var result = Reformat(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string Reformat(string s)
        {
            var digits = new Stack<char>();
            var chars = new Stack<char>();
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                    digits.Push(c);
                else
                    chars.Push(c);
            }

            if (Math.Abs(digits.Count - chars.Count) >= 2)
                return string.Empty;
            Stack<char> bigger;
            Stack<char> smaller;
            if (digits.Count > chars.Count)
            {
                bigger = digits;
                smaller = chars;
            }
            else
            {
                bigger = chars;
                smaller = digits;
            }

            var result = new StringBuilder();
            while (smaller.Any())
            {
                result.Append(bigger.Pop());
                result.Append(smaller.Pop());
            }

            if (bigger.Any())
                result.Append(bigger.Pop());

            return result.ToString();
        }
    }
}
