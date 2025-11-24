using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3222 : IProblem
    {
        public bool Test()
        {
            var x = 2;
            var y = 7;

            var expected = "Alice";

            var result = WinningPlayer(x, y);

            Console.WriteLine(result);

            return expected == result;
        }

        public string WinningPlayer(int x, int y)
        {
            var yTurns = y / 4;
            return Math.Min(x, yTurns) % 2 == 0 ? "Bob" : "Alice";
        }
    }
}
