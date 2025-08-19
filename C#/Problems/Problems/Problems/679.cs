using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
     public class _679 : IProblem
    {
        public bool Test()
        {
            var cards = new[] { 1, 9, 1, 2 };

            var expected = true;

            var result = JudgePoint24(cards);

            return expected ==  result;
        }

        public bool JudgePoint24(int[] cards)
        {
            return JudgePoint24Rec(cards.Select(x => (double)x).ToList());
        }

        public bool JudgePoint24Rec(List<double> cards)
        {
            if (cards.Count == 1)
            {
                if (Math.Abs(cards[0] - 24) < 1e-5)
                    return true;
                return false;
            }

            var n = cards.Count;

            for (int i = 0; i < n; ++i)
            {
                var a = cards[i];
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                        continue;
                    var b = cards[j];
                    var possibleResults = new List<double>();
                    var remaining = new List<double>();
                    for (int k = 0; k < n; ++k)
                    {
                        if (k != i && k != j)
                            remaining.Add(cards[k]);
                    }
                    possibleResults.Add(a + b);
                    possibleResults.Add(a - b);
                    possibleResults.Add(a * b);
                    if (a != 0)
                        possibleResults.Add(a / b);
                    if (b != 0)
                        possibleResults.Add(b/ a);
                    foreach (var poss in possibleResults)
                        if (JudgePoint24Rec(new List<double>(remaining) { poss }))
                            return true;
                }
            }

            return false;
        }
    }
}
