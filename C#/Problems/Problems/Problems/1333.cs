using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1333 : IProblem
    {
        public bool Test()
        {
            var restaurants = new[] {new[] {1, 4, 1, 40, 10}, new[] {2, 8, 0, 50, 5}, new[] {3, 8, 1, 30, 4}, new[] {4, 10, 0, 10, 3}, new[] {5, 1, 1, 15, 1}};
            var veganFriendly = 1;
            var maxPrice = 50;
            var maxDistance = 10;

            var expected = new[] { 3, 1, 5 };

            var result = FilterRestaurants(restaurants, veganFriendly, maxPrice, maxDistance);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance)
        {
            var result = new List<int>();
            var ratings = new Dictionary<int, int>();
            foreach (var r in restaurants)
            {
                if (veganFriendly == 1 && r[2] == 0)
                    continue;
                if (r[3] <= maxPrice && r[4] <= maxDistance)
                {
                    result.Add(r[0]);
                    ratings[r[0]] = r[1];
                }
            }
            return result.OrderBy(x => -ratings[x]).ThenBy(x => -x).ToList();
        }
    }
}
