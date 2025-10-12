using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _709 : IProblem
    {
        public bool Test()
        {
            var s = "Hello";

            var expected = "hello";

            var result = ToLowerCase(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}
