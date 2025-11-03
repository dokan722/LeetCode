using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1962 : IProblem
    {
        public bool Test()
        {
            var piles = new[] { 4, 3, 6, 7 };
            var k = 3;

            var expected = 12;

            var result = MinStoneSum(piles, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinStoneSum(int[] piles, int k)
        {
            var n = piles.Length;
            var que = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var sum = 0;
            foreach (var pile in piles)
            {
                que.Enqueue(pile, pile);
                sum += pile;
            }

            for (int i = 0; i < k; ++i)
            {
                var next = que.Dequeue();
                var toRemove =  next / 2;
                if (toRemove == 0)
                    break;
                sum -= toRemove;
                var newPile = next - toRemove;
                que.Enqueue(newPile, newPile);
            }

            return sum;
        }
    }
}
