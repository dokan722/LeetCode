from .problem import Problem


class Problem2410(Problem):
    def test(self):
        players = [4, 7, 9]
        trainers = [8, 2, 5, 8]

        expected = 2
        result = self.matchPlayersAndTrainers(players, trainers)

        print(result)

        return result == expected

    def matchPlayersAndTrainers(self, players, trainers):
        players.sort()
        trainers.sort()
        i = 0
        j = 0
        result = 0
        while i < len(players) and j < len(trainers):
            if players[i] <= trainers[j]:
                result += 1
                i += 1
            j += 1

        return result