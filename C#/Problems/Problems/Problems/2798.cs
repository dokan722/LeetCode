using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2798 : IProblem
    {
        public bool Test()
        {
            var hours = new[] { 5, 1, 4, 2, 2 };
            var target = 6;

            var expected = 0;

            var result = NumberOfEmployeesWhoMetTarget(hours, target);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            var result = 0;

            foreach (var hour in hours)
                if (hour >= target)
                    result++;

            return result;
        }
    }
}
