using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _874 : IProblem
    {
        public bool Test()
        {
            var commands = new[] { 4, -1, 3 };
            var obstacles = new int[][] { };

            var expected = 25;

            var result = RobotSim(commands, obstacles);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RobotSim(int[] commands, int[][] obstacles)
        {
            var obs = new HashSet<(int X, int Y)>();
            foreach (var o in obstacles)
                obs.Add((o[0], o[1]));
            var dirs = new (int X, int Y)[] { (0, 1), (1, 0), (0, -1), (-1, 0) };
            var curDir = 0;
            var x = 0;
            var y = 0;
            var result = 0;
            foreach (var cmd in commands)
            {
                if (cmd == -1)
                    curDir = (curDir + 1) % 4;
                else if (cmd == -2)
                    curDir = (curDir - 1 + 4) % 4;
                else
                {
                    for (int i = 0; i < cmd; ++i)
                    {
                        x += dirs[curDir].X;
                        y += dirs[curDir].Y;
                        if (obs.Contains((x, y)))
                        {
                            x -= dirs[curDir].X;
                            y -= dirs[curDir].Y;
                            break;
                        }
                        result = Math.Max(result, x * x + y * y);
                    }
                }
            }
            return result;
        }
    }
}
