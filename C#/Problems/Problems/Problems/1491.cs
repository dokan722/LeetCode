using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1491 : IProblem
    {
        public bool Test()
        {
            var salary = new[] { 4000, 3000, 1000, 200 };

            var expected = 2000.0;

            var result = Average(salary);

            Console.WriteLine(result);

            return result == expected;
        }

        public double Average(int[] salary)
        {
            var n = salary.Length;
            var s = 0;
            var mx = 0;
            var mn = int.MaxValue;
            foreach (var sal in salary)
            {
                s += sal;
                mx = Math.Max(mx, sal);
                mn = Math.Min(mn, sal);
            }

            return (double)(s - mx - mn) / (n - 2);
        }
    }
}
