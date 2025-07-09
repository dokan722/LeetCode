using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1128 : IProblem
    {
        public bool Test()
        {
            var dominoes = new int[][] {new int[] {1, 2}, new int[] {2, 1}, new int[] {3, 4}, new int[] {5, 6}};
            var expected = 1;
            var result = NumEquivDominoPairs(dominoes);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var counts = new int[100];
            var result = 0;
            foreach (var domino in dominoes)
            {
                var id = domino[0] > domino[1] ? domino[0] * 10 + domino[1] : domino[1] * 10 + domino[0];
                result += counts[id];
                counts[id]++;
            }
            return result;
        }
    }
}
