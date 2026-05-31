using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2126 : IProblem
    {
        public bool Test()
        {
            var mass = 10;
            var asteroids = new[] { 3, 9, 19, 5, 21 };

            var expected = true;

            var result = AsteroidsDestroyed(mass, asteroids);

            return result == expected;
        }

        public bool AsteroidsDestroyed(int mass, int[] asteroids)
        {
            long curMass = mass;
            Array.Sort(asteroids);
            foreach (var a in asteroids)
            {
                if (a > curMass)
                    return false;
                curMass += a;
            }

            return true;
        }
    }
}
