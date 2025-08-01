using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3248 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var commands = new List<string>() { "RIGHT", "DOWN" };

            var expected = 3;

            var result = FinalPositionOfSnake(n, commands);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FinalPositionOfSnake(int n, IList<string> commands)
        {
            var x = 0;
            var y = 0;
            foreach (var command in commands)
            {
                if (command == "RIGHT")
                    y++;
                else if (command == "LEFT")
                    y--;
                else if (command == "UP")
                    x--;
                else
                    x++;
            }

            return x * n + y;
        }
    }
}
