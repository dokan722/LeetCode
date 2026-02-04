using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2957 : IProblem
    {
        public bool Test()
        {
            var word = "zyxyxyz";

            var expected = 3;

            var result = RemoveAlmostEqualCharacters(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RemoveAlmostEqualCharacters(string word)
        {
            var n = word.Length;
            var changed = new bool[n];
            var count = 0;
            for (int i = 1; i < n; ++i)
            {
                if (!changed[i - 1] && Math.Abs(word[i] - word[i - 1]) < 2)
                {
                    count++;
                    changed[i] = true;
                }
            }

            return count;
        }
    }
}
