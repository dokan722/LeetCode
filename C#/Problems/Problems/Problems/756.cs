using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _756 : IProblem
    {
        public bool Test()
        {
            var bottom = "BCD";
            var allowed = new[] { "BCC", "CDE", "CEA", "FFF" };

            var expected = true;

            var result = PyramidTransition(bottom, allowed);

            return expected == result;
        }

        private readonly Dictionary<(char, char), List<char>> _patterns = new();

        public bool PyramidTransition(string bottom, IList<string> allowed)
        {
            if (!_patterns.Any())
            {
                foreach (var a in allowed)
                {
                    var key = (a[0], a[1]);
                    if (_patterns.ContainsKey(key))
                        _patterns[key].Add(a[2]);
                    else
                        _patterns[key] = new List<char> { a[2] };
                }
            }
            var n = bottom.Length;
            if (n == 0)
                return true;
            var poss = new List<string> { "" };
            for (int i = 0; i < n - 1; ++i)
            {
                var key = (bottom[i], bottom[i + 1]);
                if (!_patterns.ContainsKey(key))
                    return false;
                var newPoss = new List<string>();
                foreach (var c in _patterns[key])
                {
                    foreach (var p in poss)
                    {
                        newPoss.Add(p + c);
                    }
                }

                poss = newPoss;
            }

            foreach (var p in poss)
            {
                if (PyramidTransition(p, allowed))
                    return true;
            }

            return false;
        }
    }
}
