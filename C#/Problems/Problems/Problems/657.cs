using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _657 : IProblem
    {
        public bool Test()
        {
            var moves = "UD";

            var expected = true;

            var result = JudgeCircle(moves);

            return expected == result;
        }

        public bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;
            foreach (var move in moves)
            {
                if (move == 'U')
                    x++;
                else if (move == 'D')
                    x--;
                else if (move == 'L')
                    y++;
                else if (move == 'R')
                    y--;
            }

            return x == 0 && y == 0;
        }
    }
}
