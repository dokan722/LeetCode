using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly166
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            var s = "UU";
            var k = 1;

            var expected = 1;

            var result = DistinctPoints(s, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int DistinctPoints(string s, int k)
        {
            var n = s.Length;
            if (k == n)
                return 1;
            var coords = (0, 0);
            var visited = new HashSet<(int, int)>();
            for (int i = 0; i < k; ++i)
                coords = Move(coords.Item1, coords.Item2, s[i]);
            visited.Add(coords);

            var reversedMoves = new Dictionary<char, char> { { 'U', 'D' }, { 'D', 'U' }, { 'L', 'R' }, { 'R', 'L' } };
            for (int i = 0; i + k < n; ++i)
            {
                coords = Move(coords.Item1, coords.Item2, reversedMoves[s[i]]);
                coords = Move(coords.Item1, coords.Item2, s[i + k]);
                visited.Add(coords);
            }

            return visited.Count;
        }

        private (int, int) Move(int x, int y, char move)
        {
            if (move == 'U')
                return (x, y + 1);
            if (move == 'D')
                return (x, y - 1);
            if (move == 'L')
                return (x - 1, y);
            return (x + 1, y);
        }
    }
}
