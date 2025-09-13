using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly165
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var expected = new[]
            {
                new[] { 0, 1 }, new[] { 2, 3 }, new[] { 0, 4 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 0, 2 },
                new[] { 1, 3 }, new[] { 2, 4 }, new[] { 0, 3 }, new[] { 1, 4 }, new[] { 2, 0 }, new[] { 3, 1 },
                new[] { 4, 0 }, new[] { 2, 1 }, new[] { 4, 3 }, new[] { 1, 0 }, new[] { 3, 2 }, new[] { 4, 1 },
                new[] { 3, 0 }, new[] { 4, 2 }
            };
            
            var result = GenerateSchedule(n);

            Console.WriteLine(expected.Length);

            return true;
        }

        public int[][] GenerateSchedule(int n)
        {
            if (n < 4) 
                return new int[0][];
            var numMatches = n * (n - 1);
            var matchesToPlay = Enumerable.Repeat(2* (n - 1), n).ToArray();
            var result = new int[numMatches][];
            var playedMatches = new bool[n][];
            for (int i = 0; i < n; i++)
                playedMatches[i] = Enumerable.Repeat(false, n).ToArray();
            var used1 = -1;
            var used2 = -1;
            for (int i = 0; i < numMatches; ++i)
            {
                var avbTeams = Enumerable.Range(0, n).Where(x => x != used1 && x != used2);
                foreach (var firstTeam in avbTeams)
                {
                    var secondTeamPoss = avbTeams.Where(x =>
                        (!playedMatches[firstTeam][x] || !playedMatches[x][firstTeam]) && x != firstTeam);
                    if (!secondTeamPoss.Any())
                        continue;
                    var secondTeam = secondTeamPoss.MaxBy(x => matchesToPlay[x]);
                    if (!playedMatches[firstTeam][secondTeam])
                    {
                        playedMatches[firstTeam][secondTeam] = true;
                        result[i] = new[] { firstTeam, secondTeam };
                    }
                    else
                    {
                        playedMatches[secondTeam][firstTeam] = true;
                        result[i] = new[] { secondTeam, firstTeam };
                    }

                    used1 = firstTeam;
                    used2 = secondTeam;
                    matchesToPlay[firstTeam]--;
                    matchesToPlay[secondTeam]--;
                    break;
                }
            }

            return result;
        }
    }
}
