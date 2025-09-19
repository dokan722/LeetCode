using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1282 : IProblem
    {
        public bool Test()
        {
            var groupSizes = new[] { 3, 3, 3, 3, 3, 1, 3 };

            var expected = new List<IList<int>> { new List<int> { 0, 1, 2 }, new List<int> {5}, new List<int> {3, 4, 6}};

            var result = GroupThePeople(groupSizes);

            return true;
        }

        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var n = groupSizes.Length;
            var lists = new Dictionary<int, List<int>>();
            var result = new List<IList<int>>();
            for (int i = 0; i < n; ++i)
            {
                var size = groupSizes[i];
                if (!lists.ContainsKey(size))
                    lists[size] = new List<int>();
                if (lists[size].Count == size - 1)
                {
                    lists[size].Add(i);
                    result.Add(lists[size]);
                    lists.Remove(size);
                }
                else
                    lists[size].Add(i);
            }

            return result;
        }
    }
}
