using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2410 : IProblem
    {
        public bool Test()
        {
            var players = new int[] { 4, 7, 9 };
            var trainers = new int[] { 8, 2, 5, 8 };

            var expected = 2;
            var result = MatchPlayersAndTrainers(players, trainers);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);
            int i = 0;
            int j = 0;
            var result = 0;
            while (i < players.Length && j < trainers.Length)
            {
                if (players[i] <= trainers[j])
                {
                    result++;
                    i++;
                }
                j++;
            }

            return result;
        }
    }
}
