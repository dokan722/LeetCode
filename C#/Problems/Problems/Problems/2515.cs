using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2515 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "hello", "i", "am", "leetcode", "hello" };
            var target = "hello";
            var startIndex = 1;

            var expected = 1;

            var result = ClosestTarget(words, target, startIndex);

            Console.WriteLine(result);

            return result == expected;
        }
        public int ClosestTarget(string[] words, string target, int startIndex)
        {
            var n = words.Length;
            var result = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                var cur = (startIndex + i) % n;
                if (words[cur] == target)
                    result = Math.Min(result, Math.Min(i, n - i));
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
