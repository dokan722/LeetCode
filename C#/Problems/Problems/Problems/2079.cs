using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2079 : IProblem
    {
        public bool Test()
        {
            var plants = new int[] { 3, 2, 4, 2, 1 };
            var capacity = 6;

            var expected = 17;

            var result = WateringPlants(plants, capacity);

            Console.WriteLine(result);

            return result == expected;
        }
        public int WateringPlants(int[] plants, int capacity)
        {
            var n = plants.Length;
            var curr = capacity;
            var result = n;
            for (int i = 0; i < n; i++)
            {
                if (curr < plants[i])
                {
                    result += 2 * i;
                    curr = capacity - plants[i];
                }
                else
                    curr -= plants[i];
            }

            return result;
        }
    }
}
