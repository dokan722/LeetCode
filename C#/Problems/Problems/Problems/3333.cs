using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // NOT SOLVED
    public class _3333 : IProblem
    {
        public bool Test()
        {
            var word = "aabbccdd";
            var k = 7;

            var expected = 5;

            var result = PossibleStringCount(word, k);

            Console.WriteLine(result);
            
            return result == expected;
        }

        public int PossibleStringCount(string word, int k)
        {
            var len = 1;
            var prev = word[0];
            long minLen = 0;
            long possibleExtraLetters = 0;

            for (int i = 1; i < word.Length; i++)
            {
                if (prev != word[i])
                {
                    possibleExtraLetters += (len - 1);
                    minLen++;
                    len = 1;
                    prev = word[i];
                }
                else
                    len++;
            }

            possibleExtraLetters += (len - 1);
            minLen++;

            long maxToDelete = possibleExtraLetters - (k - minLen);
            long result = 0;
            long mod = 1000000007L;
            if (maxToDelete < possibleExtraLetters / 2)
            {
                for (int i = 0; i <= maxToDelete; i++)
                    result = (result + BinomialCoefficientWithModulo(possibleExtraLetters, i, mod)) % mod;
            }
            else
            {
                long part = 0;
                for (int i = 0; i <= (possibleExtraLetters - maxToDelete); i++)
                    part = (part + BinomialCoefficientWithModulo(possibleExtraLetters, i, mod)) % mod;
                result = (PowerWithModulo(2, possibleExtraLetters, mod) - part) % mod;
            }

            return (int)result;
        }

        private long PowerWithModulo(long a, long n, long m)
        {
            long result = 1;
            a %= m;

            while (n > 0)
            {
                if ((n & 1) == 1)
                    result = (result * a) % m;

                a = (a * a) % m;
                n >>= 1;
            }

            return result;
        }

        private long BinomialCoefficientWithModulo(long n, long k, long m)
        {
            if (k < 0 || k > n)
                return 0;
            if (k == 0 || k == n)
                return 1;

            long numerator = 1;
            long denominator = 1;

            for (int i = 0; i < k; i++)
            {
                numerator = (numerator * (n - i)) % m;
                denominator = (denominator * (i + 1)) % m;
            }

            long inverseDenominator = PowerWithModulo(denominator, m - 2, m);
            return (numerator * inverseDenominator) % m;
        }
    }
}
