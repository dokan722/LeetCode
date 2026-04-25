using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2833 : IProblem
    {
        public bool Test()
        {
            var moves = "L_RL__R";

            var expected = 3;

            var result = FurthestDistanceFromOrigin(moves);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FurthestDistanceFromOrigin(string moves)
        {
            var left = 0;
            var right = 0;
            var wild = 0;
            foreach (var m in moves)
            {
                if (m == '_')
                    wild++;
                else if (m == 'R')
                    right++;
                else
                    left++;
            }

            return Math.Abs(left - right) + wild;
        }
    }
}
