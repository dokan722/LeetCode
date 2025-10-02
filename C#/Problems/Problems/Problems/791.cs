using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _791 : IProblem
    {
        public bool Test()
        {
            var order = "cba";
            var s = "abcd";

            var expected = "cbad";

            var result = CustomSortString(order, s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string CustomSortString(string order, string s)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;

            var result = new StringBuilder();
            foreach (var c in order)
            {
                result.Append(new string(c, counts[c - 'a']));
                counts[c - 'a'] = 0;
            }

            for (int i = 0; i < counts.Length; ++i)
            {
                result.Append(new string((char)(i + 'a'), counts[i]));
            }

            return result.ToString();
        }
    }
}
