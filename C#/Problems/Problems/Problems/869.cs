using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _869 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = false;

            var result = ReorderedPowerOf2(n);

            return result == expected;
        }

        public bool ReorderedPowerOf2(int n)
        {
            return _sortedPowers.Contains(string.Join("", n.ToString().OrderBy(x => x)));
        }

        private List<string> _sortedPowers = new List<string>
        {
            "1",
            "2",
            "4",
            "8",
            "16",
            "23",
            "46",
            "128",
            "256",
            "125",
            "0124",
            "0248",
            "0469",
            "1289",
            "13468",
            "23678",
            "35566",
            "011237",
            "122446",
            "224588",
            "0145678",
            "0122579",
            "0134449",
            "0368888",
            "11266777",
            "23334455",
            "01466788",
            "112234778",
            "234455668",
            "012356789",
            "0112344778"
        };
    }
}
