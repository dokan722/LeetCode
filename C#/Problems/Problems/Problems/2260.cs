using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2260 : IProblem
    {
        public bool Test()
        {
            var cards = new[] { 3, 4, 2, 3, 4, 7 };

            var expected = 4;

            var result = MinimumCardPickup(cards);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumCardPickup(int[] cards)
        {
            var n = cards.Length;
            var pos = new Dictionary<int, int>();
            var result = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                if (pos.ContainsKey(cards[i]))
                    result = Math.Min(result, i - pos[cards[i]] + 1);
                pos[cards[i]] = i;
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
