using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2353 : IProblem
    {
        public bool Test()
        {
            var foods = new[] { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" };
            var cuisines = new[] { "korean", "japanese", "japanese", "greek", "japanese", "korean" };
            var ratings = new[] { 9, 12, 8, 15, 14, 7 };

            var foodRatings = new FoodRatings(foods, cuisines, ratings);
            if (foodRatings.HighestRated("korean") != "kimchi")
                return false;
            if (foodRatings.HighestRated("japanese") != "ramen")
                return false;
            foodRatings.ChangeRating("sushi", 16);
            if (foodRatings.HighestRated("japanese") != "sushi")
                return false;
            foodRatings.ChangeRating("ramen", 16);
            if (foodRatings.HighestRated("japanese") != "ramen")
                return false;


            return true;
        }
    }

    public class FoodRatings
    {
        private readonly Dictionary<string, PriorityQueue<int, (int Rating, string Food)>> _cuisineRatings;
        private readonly Dictionary<string, int> _versions;
        private readonly Dictionary<string, string> _cuisines;
        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            var n = foods.Length;
            _cuisineRatings = new();
            _versions = new();
            _cuisines = new();
            for (int i = 0; i < n; i++)
            {
                if (!_cuisineRatings.ContainsKey(cuisines[i]))
                    _cuisineRatings[cuisines[i]] = new();
                _cuisineRatings[cuisines[i]].Enqueue(0, (-ratings[i], foods[i]));
                _versions[foods[i]] = 0;
                _cuisines[foods[i]] = cuisines[i];
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            _versions[food]++;
            _cuisineRatings[_cuisines[food]].Enqueue(_versions[food], (-newRating, food));
        }

        public string HighestRated(string cuisine)
        {
            var queue = _cuisineRatings[cuisine];
            while (queue.TryPeek(out var version, out var prio) && version != _versions[prio.Food])
                queue.Dequeue();
            queue.TryPeek(out var _, out var item);
            return item.Food;
        }
    }
}
