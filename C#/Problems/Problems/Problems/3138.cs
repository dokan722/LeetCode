using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3138 : IProblem
    {
        public bool Test()
        {
            var s = "aabbabab";

            var expected = 4;

            var result = MinAnagramLength(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinAnagramLength(string s)
        {
            var n = s.Length;
            var counts = CountLetters(s);

            var nonZero = new List<int>();
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] != 0)
                    nonZero.Add(counts[i]);
            }

            if (nonZero.Count == 1)
                return 1;

            var totalGcd = gcd(Math.Max(nonZero[0], nonZero[1]), Math.Min(nonZero[0], nonZero[1]));

            for (int i = 2; i < nonZero.Count; ++i)
            {
                totalGcd = gcd(Math.Max(nonZero[i], totalGcd), Math.Min(nonZero[i], totalGcd));
            }

            for (int i = totalGcd; i > 1; --i)
            {
                if (n % totalGcd != 0)
                    continue;
                var works = true;
                for (int j = 0; j < i; ++j)
                {
                    var thisCount = CountLetters(s.Substring(j * n / i, n / i));
                    
                    for (int k = 0; k < 26; k++)
                    {
                        if (counts[k] != thisCount[k] * i)
                        {
                            works = false;
                            break;
                        }
                    }
                }
                if (works)
                    return n / i;
            }

            return n;
        }

        private int[] CountLetters(string s)
        {
            var counts = new int[26];
            foreach (char c in s)
            {
                counts[c - 'a']++;
            }

            return counts;
        }


        private int gcd(int bigger, int lower)
        {
            var rest = bigger % lower;
            if (rest == 0)
                return lower;
            return gcd(lower, rest);
        }
    }
}
