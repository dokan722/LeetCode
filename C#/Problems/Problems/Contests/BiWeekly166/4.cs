using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly166
{
    public class _4 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 440079756, 692355652, 858262497, 613156265, 654515912 };
            var swaps = new[] {  new[] { 0, 1 }, new[] { 2, 3 }, new[] { 1, 4 }, new[] { 2, 4 } };

            var expected = 2;

            var result = MaxAlternatingSum(nums, swaps);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MaxAlternatingSum(int[] nums, int[][] swaps)
        {
            var n = nums.Length;
            var clusters = Enumerable.Repeat(-1, n).ToArray();
            var clusterNum = 0;
            var groups = new Dictionary<int, SortedSet<(int, int)>>();
            foreach (var swap in swaps)
            {
                if (clusters[swap[0]] == -1 && clusters[swap[1]] == -1)
                {
                    clusters[swap[0]] = clusterNum;
                    clusters[swap[1]] = clusterNum;
                    groups[clusterNum] = new SortedSet<(int, int)> { (nums[swap[0]], swap[0]), ( nums[swap[1]], swap[1]) };
                    clusterNum++;
                }
                else if (clusters[swap[0]] == -1 || clusters[swap[1]] == -1)
                {
                    var groupNum = Math.Max(clusters[swap[0]], clusters[swap[1]]);
                    clusters[swap[0]] = groupNum;
                    clusters[swap[1]] = groupNum;
                    groups[groupNum].Add((nums[swap[0]], swap[0]));
                    groups[groupNum].Add((nums[swap[1]], swap[1]));
                }
                else if (clusters[swap[0]] != clusters[swap[1]])
                {
                    var groupNum = groups[clusters[swap[0]]].Count > groups[clusters[swap[0]]].Count ? clusters[swap[0]] : clusters[swap[1]];
                    var removeGroupNum = groupNum == clusters[swap[0]] ? clusters[swap[1]] : clusters[swap[0]];
                    foreach (var id in groups[removeGroupNum])
                    {
                        clusters[id.Item2] = groupNum;
                        groups[groupNum].Add(id);
                    }
                    groups.Remove(removeGroupNum);
                }
            }

            long maxSum = 0;
            foreach (var group in groups.Values)
            {
                var even = 0;
                foreach (var id in group)
                {
                    if (id.Item2 % 2 == 0)
                        even++;
                }
                var odd = group.Count - even;
                var i = 0;
                foreach (var num in group)
                {
                    if (i < odd)
                        maxSum -= num.Item1;
                    else
                        maxSum += num.Item1;
                    i++;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                if (clusters[i] != -1)
                    continue;
                if (i % 2 == 0)
                    maxSum += nums[i];
                else
                    maxSum -= nums[i];
            }

            return maxSum;
        }
    }
}
