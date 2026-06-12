using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2114 : IProblem
    {
        public bool Test()
        {
            var sentences = new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

            var expected = 6;

            var result = MostWordsFound(sentences);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MostWordsFound(string[] sentences)
        {
            var result = 0;
            foreach (var s in sentences)
            {
                var cur = 1;
                foreach (var c in s)
                    if (c == ' ')
                        cur++;
                result = Math.Max(result, cur);
            }
            return result;
        }
    }
}
