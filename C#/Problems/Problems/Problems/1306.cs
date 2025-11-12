using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1306 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 4, 2, 3, 0, 3, 1, 2 };
            var start = 5;

            var expected = true;

            var result = CanReach(arr, start);

            return result == expected;
        }

        public bool CanReach(int[] arr, int start)
        {
            var n = arr.Length;
            var visited = new bool[n];
            var jumpStack = new Stack<int>();
            jumpStack.Push(start);
            while (jumpStack.TryPop(out var id))
            {
                if (!visited[id])
                {
                    if (arr[id] == 0)
                        return true;
                    visited[id] = true;
                    if (id - arr[id] >= 0)
                        jumpStack.Push(id - arr[id]);
                    if (id + arr[id] < n)
                        jumpStack.Push(id + arr[id]);
                }
            }

            return false;
        }
    }
}
