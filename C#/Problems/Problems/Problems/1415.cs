using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1415 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var k = 9;

            var expected = "cab";

            var result = GetHappyString(n, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public string GetHappyString(int n, int k)
        {
            var chars = new char[3] { 'a', 'b', 'c' };
            var result = new List<string>() {"a", "b", "c"};
            for (int i = 1; i < n; i++)
            {
                var newResult = new List<string>();
                foreach (var s in result)
                    foreach (var c in chars)
                    {
                        if (c == s[s.Length - 1])
                            continue;
                        newResult.Add(s + c);
                    }
                result = newResult;
            }

            if (k > result.Count)
                return "";

            return result[k - 1];
        }
    }
}
