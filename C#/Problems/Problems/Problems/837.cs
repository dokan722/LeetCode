using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _837 : IProblem
    {
        public bool Test()
        {
            var n = 21;
            var k = 17;
            var maxPts = 10;

            var expected = 0.73278;

            var result = New21Game(n, k, maxPts);

            Console.WriteLine(result);

            return Math.Abs(expected - result) < 1e-5;
        }

        public double New21Game(int n, int k, int maxPts)
        {
            var probs = new double[n + 1];
            probs[0] = 1;
            var sumProb = 0.0;
            for (int i = 1; i <= n; ++i)
            {
                var start = i - maxPts - 1;
                if (start < k && start >= 0)
                    sumProb -= probs[start] / maxPts;
                if (i <= k)
                    sumProb += probs[i - 1] / maxPts;
                probs[i] = sumProb;
            }

            var result = 0.0;
            for (int i = k; i <= n; ++i)
                result += probs[i];

            return result;
        }
    }
}
