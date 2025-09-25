using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3612 : IProblem
    {
        public bool Test()
        {
            var s = "a#b%*";

            var expected = "ba";

            var result = ProcessStr(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string ProcessStr(string s)
        {
            var result = new List<char>();
            foreach (var c in s)
            {
                if (c == '*')
                {
                    if (result.Count > 0)
                        result.RemoveAt(result.Count - 1);
                }
                else if (c == '#')
                    result.AddRange(result);
                else if (c == '%')
                    result.Reverse();
                else
                    result.Add(c);
            }

            return string.Join("", result);
        }
    }
}
