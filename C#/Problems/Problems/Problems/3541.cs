using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3541 : IProblem
    {
        public bool Test()
        {
            var s = "successes";

            var expected = 6;

            var result = MaxFreqSum(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxFreqSum(string s)
        {
            var counts = new int[26];

            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            var maxVow = 0;
            var maxCons = 0;
            for (int i = 0; i < 26; ++i)
            {
                var letter = i + 'a';
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    if (counts[i] > maxVow)
                        maxVow = counts[i];
                }
                else
                {
                    if (counts[i] > maxCons)
                        maxCons = counts[i];
                }
            }

            return maxVow + maxCons;
        }
    }
}
