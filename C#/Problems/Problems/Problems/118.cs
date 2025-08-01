using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _118 : IProblem
    {
        public bool Test()
        {
            int n = 5;

            var expected = new[] { new[] { 1 }, new[] { 1,1 }, new[] { 1,2,1 }, new[] { 1,3,3,1 }, new[] { 1,4,6,4,1 } };

            var result = Generate(n);
            foreach (var e in expected.Zip(result))
            {
                if (!e.First.SequenceEqual(e.Second))
                    return false;
            }

            return true;
        }

        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var prev = new List<int> { 1 };
            result.Add(prev);
            for (int i = 1; i < numRows; ++i)
            {
                var row = new List<int>() { 1 };
                for (int j = 0; j < prev.Count - 1; ++j)
                    row.Add(prev[j] + prev[j + 1]);
                row.Add(1);
                result.Add(row);
                prev = row;
            }

            return result;
        }
    }
}
