using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1041 : IProblem
    {
        public bool Test()
        {
            var instructions = "GL";

            var expected = true;

            var result = IsRobotBounded(instructions);

            return result == expected;
        }

        public bool IsRobotBounded(string instructions)
        {
            var dirs = new int[4];
            var curr = 0;
            foreach (var instruction in instructions)
            {
                if (instruction == 'G')
                    dirs[curr]++;
                else if (instruction == 'R')
                    curr = (curr + 1) % 4;
                else
                    curr = (curr + 3) % 4;
            }


            return curr != 0 || dirs[0] == dirs[2] && dirs[1] == dirs[3];
        }
    }
}
