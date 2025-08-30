using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly164
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var cards = new[] { "ab", "aa", "ab", "bc", "cc", "bc", "bb", "ac", "bc", "bc", "aa", "aa", "ba", "bc", "cb", "ba", "ac", "bb", "cb", "ac", "cb", "cb", "ba", "bc", "ca", "ba", "bb", "cc", "cc", "ca", "ab", "bb", "bc", "ba", "ac", "bc", "ac", "ac", "bc", "bb", "bc", "ac", "bc", "aa", "ba", "cc", "ac", "bb", "ba", "bb"};

            var x = 'b';

            var expected = 2;

            var result = Score(cards, x);

            Console.WriteLine(result);

            return expected == result;
        }

        public int Score(string[] cards, char x)
        {
            var same = 0;
            var countsFirst = new int[26];
            var countsSecond = new int[26];
            var score = 0;
            foreach (var card in cards)
            {
                if (card[0] == x && card[1] == x)
                    same++;
                else if (card[0] == x)
                    countsFirst[card[1] - 'a']++;
                else if (card[1] == x)
                    countsSecond[card[0] - 'a']++;
            }
            var fmax = countsFirst.Max();
            var fsum = countsFirst.Sum();
            int fret;
            if (2 * fmax > fsum)
                fret = (fsum - fmax);
            else
                fret = fsum / 2;
            var fleft = fsum - (fret * 2);

            var smax = countsSecond.Max();
            var ssum = countsSecond.Sum();
            int sret;
            if (2 * smax > ssum)
                sret = (ssum - smax);
            else
                sret = ssum / 2;
            var sleft = ssum - (sret * 2);

            int additional;
            if (same < sleft + fleft)
                additional = same;
            else
            {
                additional = sleft + fleft;
                var rem = same - additional;
                additional += Math.Min(rem / 2, fret + sret);
            }
            return fret + sret + additional;
        }
    }
}
