using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3968 : IProblem
    {
        public bool Test()
        {
            var moves = "L_D_";

            var expected = 4;

            var result = MaxDistance(moves);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDistance(string moves)
        {
            var x = 0;
            var y = 0;
            var b = 0;
            foreach (var m in moves)
            {
                if (m == 'U')
                    x++;
                else if (m == 'D')
                    x--;
                else if (m == 'R')
                    y++;
                else if (m == 'L')
                    y--;
                else
                    b++;
            }

            return Math.Abs(x) + Math.Abs(y) + b;
        }
    }
}
