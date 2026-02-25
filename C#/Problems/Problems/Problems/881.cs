using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _881 : IProblem
    {
        public bool Test()
        {
            var people = new[] { 3, 2, 2, 1 };
            var limit = 3;

            var expected = 3;

            var result = NumRescueBoats(people, limit);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            var l = 0;
            var r = people.Length - 1;
            var result = 0;
            while (l < r)
            {
                if (people[l] + people[r] <= limit)
                {
                    l++;
                    r--;
                }
                else
                    r--;
                result++;
            }
            if (l == r)
                result++;
            return result;
        }
    }
}
