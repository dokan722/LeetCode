using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3433 : IProblem
    {
        public bool Test()
        {
            var numberOfUsers = 2;
            var events = new List<IList<string>> {new List<string> {"MESSAGE", "10", "id1 id0"}, new List<string> { "OFFLINE", "11", "0"}, new List<string> { "MESSAGE", "71", "HERE"}};

            var expected = new[] { 2, 2 };

            var result = CountMentions(numberOfUsers, events);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] CountMentions(int numberOfUsers, IList<IList<string>> events)
        {
            var online = new int[numberOfUsers];
            events = events.OrderBy(x => int.Parse(x[1])).ThenByDescending(x => x[0]).ToList();
            var result = new int[numberOfUsers];
            var alls = 0;
            foreach (var e in events)
            {
                if (e[0][0] == 'O')
                {
                    var ts = int.Parse(e[1]);
                    var id = int.Parse(e[2]);
                    online[id] = ts + 60;
                }
                else
                {
                    if (e[2][0] == 'A')
                        alls += 1;
                    else if (e[2][0] == 'H')
                    {
                        var ts = int.Parse(e[1]);
                        for (int i = 0; i < numberOfUsers; ++i)
                        {
                            if (online[i] <= ts)
                                result[i]++;
                        }
                    }
                    else
                    {
                        var ids = e[2].Split(' ').Select(x => int.Parse(x.Substring(2)));
                        foreach (var id in ids)
                                result[id]++;
                    }
                }
            }
            if (alls > 0)
                for (int i = 0; i < numberOfUsers; ++i)
                    result[i] += alls;

            return result;
        }
    }
}
