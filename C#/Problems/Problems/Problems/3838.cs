using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3838 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abcd", "def", "xyz" };
            var weights = new[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 };

            var expected = "rij";

            var result = MapWordWeights(words, weights);

            Console.WriteLine(result);

            return result == expected;
        }

        public string MapWordWeights(string[] words, int[] weights)
        {
            string result = "";
            foreach (var w in words)
            {
                var s = 0;
                foreach (var c in w)
                    s += weights[c - 'a'];
                result += (char)('z' - (s % 26));
            }
            return result;
        }
    }
}
