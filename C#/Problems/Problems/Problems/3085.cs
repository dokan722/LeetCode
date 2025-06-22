using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3085 : IProblem
    {
        public bool Test()
        {
            var word = "itatwtiwwi";

            var k = 1;

            var expected = 1;

            var result = MinimumDeletions(word, k);

            Console.WriteLine(result);

            return result == expected;
        }


        public int MinimumDeletions(string word, int k)
        {
            var counts = new int[26];
            foreach (var c in word)
            {
                counts[c - 'a'] += 1;
            }

            Array.Sort(counts);

            var start = 0;
            while (counts[start] == 0)
                start++;

            if (Math.Abs(counts[start] - counts[^1]) <= k)
                return 0;

            var result = int.MaxValue;
            for (int i = start; i < counts.Length; ++i)
            {
                var currMin = counts[i];
                var count = 0;
                for (int j = start; j < counts.Length; ++j)
                {
                    if (counts[j] < currMin)
                        count += counts[j];
                    else if (Math.Abs(counts[j] - currMin) > k)
                        count += counts[j] - (currMin + k);
                }
                if (count < result)
                    result = count;
            }


            return result;
        }
    }
}
