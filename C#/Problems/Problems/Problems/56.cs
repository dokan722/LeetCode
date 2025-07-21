using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _56 : IProblem
    {
        public bool Test()
        {
            var intervals = new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };

            var expected = new[] { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };

            var result = Merge(intervals);

            
            return result.Zip(expected).Select(x => x.First.SequenceEqual(x.Second)).All(x => x);
        }

        public int[][] Merge(int[][] intervals)
        {
            var maxLen = 10001;
            var overlaps = new int[maxLen];
            var oneDays = new bool[maxLen];
            var first = int.MaxValue;
            var last = int.MinValue;
            foreach (var interval in intervals)
            {
                if (interval[0] == interval[1])
                    oneDays[interval[0]] = true;
                if (interval[0] < first)
                    first = interval[0];
                if (interval[1] > last)
                    last = interval[1];
                overlaps[interval[0]]++;
                overlaps[interval[1]]--;
            }

            var result = new List<int[]>();
            var start = first;
            var runningSum = 0;
            var inside = overlaps[first] != 0;
            for (int i = first; i <= last; ++i)
            {
                runningSum += overlaps[i];
                if (inside)
                {
                    if (runningSum == 0)
                    {
                        result.Add(new[] {start, i});
                        inside = false;
                    }
                }
                else
                {
                    if (runningSum != 0)
                    {
                        start = i;
                        inside = true;
                    }
                }
                if (runningSum == 0 && overlaps[i] == 0 && oneDays[i])
                    result.Add(new[] { i, i });
                
            }


            return result.ToArray();
        }
    }
}
