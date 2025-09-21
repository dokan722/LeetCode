using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1912 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var entries = new[] { new[] {0, 1, 5}, new[] {0, 2, 6}, new[] {0, 3, 7}, new[] {1, 1, 4}, new[] {1, 2, 7}, new[] {2, 1, 5} };
            var system = new MovieRentingSystem(n, entries);
            if (!system.Search(1).SequenceEqual(new[] { 1, 0, 2 }))
                return false;
            system.Rent(0, 1);
            system.Rent(1, 2);
            if (!Utils.Compare2DArrays(system.Report().Select(x => x.ToArray()).ToArray(), new[] { new[] {0, 1}, new [] { 1, 2}}))
                return false;
            system.Drop(1, 2);
            if (!system.Search(2).SequenceEqual(new[] { 0, 1}))
                return false;

            return true;
        }

        public class MovieRentingSystem
        {
            private readonly Dictionary<int, SortedSet<(int Price, int Shop)>> _movies;
            private readonly Dictionary<(int Shop, int Movie), int> _prices;
            private readonly Dictionary<(int Shop, int Movie), bool> _status;
            private readonly SortedSet<(int Price, int Shop, int Movie)> _rented;

            public MovieRentingSystem(int n, int[][] entries)
            {
                _movies = new();
                _status = new();
                _rented = new();
                _prices = new();
                foreach (var entry in entries)
                {
                    if (!_movies.ContainsKey(entry[1]))
                        _movies[entry[1]] = new();
                    _movies[entry[1]].Add((entry[2], entry[0]));
                    _status[(entry[0], entry[1])] = true;
                    _prices[(entry[0], entry[1])] = entry[2];
                }
            }

            public IList<int> Search(int movie)
            {
                if (!_movies.ContainsKey(movie))
                    return new List<int>();
                return _movies[movie].Where(x => _status[(x.Shop, movie)]).Take(5).Select(x => x.Shop).ToList();
            }

            public void Rent(int shop, int movie)
            {
                _status[(shop, movie)] = false;
                _rented.Add((_prices[(shop, movie)], shop, movie));
            }

            public void Drop(int shop, int movie)
            {
                _status[(shop, movie)] = true;
                _rented.Remove((_prices[(shop, movie)], shop, movie));
            }

            public IList<IList<int>> Report()
            {
                return _rented.Take(5).Select(x => (IList<int>)new List<int> { x.Shop, x.Movie }).ToList();
            }
        }
    }
}
