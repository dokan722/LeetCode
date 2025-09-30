using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1344 : IProblem
    {
        public bool Test()
        {
            var hour = 12;
            var minutes = 30;

            var expected = 165;

            var result = AngleClock(hour, minutes);

            Console.WriteLine(result);

            return Math.Abs(result - expected) < 1e-5;
        }

        public double AngleClock(int hour, int minutes)
        {
            var angle = Math.Abs(hour * 30 + minutes / 2.0 - minutes * 6);
            return angle < 180 ? angle : 360 - angle;
        }
    }
}
