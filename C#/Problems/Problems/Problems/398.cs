using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _398 : IProblem
    {
        public bool Test()
        {
            return true;
        }

        protected class Solution
        {
            private Dictionary<int, List<int>> _indices;
            public Solution(int[] nums)
            {
                _indices = new();
                for (int i = 0; i < nums.Length; ++i)
                {
                    if (_indices.ContainsKey(nums[i]))
                        _indices[nums[i]].Add(i);
                    else
                        _indices[nums[i]] = new List<int> { i };
                }
            }

            public int Pick(int target)
            {
                var indices = _indices[target];
                return indices[new Random().Next(indices.Count)];
            }
        }
    }
}
