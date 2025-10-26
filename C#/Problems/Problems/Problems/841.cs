using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _841 : IProblem
    {
        public bool Test()
        {
            var rooms = new List<IList<int>> { new List<int>{1}, new List<int>{2}, new List<int>{3}, new List<int>{} };

            var expected = true;

            var result = CanVisitAllRooms(rooms);

            return expected == result;
        }

        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var n = rooms.Count;
            var covered = 0;
            var visited = new bool[n];
            var toVisit = new Stack<int>();
            toVisit.Push(0);
            while (toVisit.TryPop(out var next))
            {
                if (visited[next])
                    continue;
                covered++;
                visited[next] = true;
                foreach (var key in rooms[next])
                {
                    if (!visited[key])
                        toVisit.Push(key);
                }
            }

            return covered == n;
        }
    }
}
