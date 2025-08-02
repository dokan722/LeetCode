from typing import List

from .problem import Problem


class Problem983(Problem):
    def test(self) -> bool:
        days = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31]
        costs = [2, 7, 15]

        expected = 17

        result = self.mincostTickets(days, costs)

        print(result)

        return result == expected

    def mincostTickets(self, days: List[int], costs: List[int]) -> int:
        maxDay = days[-1]
        dailyCosts = [0] * (maxDay + 1)
        nextTravel = 0
        prevDay = 0
        for i in range(1, maxDay + 1):
            if i == days[nextTravel]:
                dailyCosts[i] = min(min(dailyCosts[i - 1] + costs[0], dailyCosts[max(0, i - 7)] + costs[1]),
                         dailyCosts[max(0, i - 30)] + costs[2])
                prevDay = dailyCosts[i]
                nextTravel += 1
            else:
                dailyCosts[i] = prevDay

        return dailyCosts[maxDay]