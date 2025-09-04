from typing import List

from .problem import Problem


class Problem1029(Problem):
    def test(self) -> bool:
        costs = [[259, 770], [448, 54], [926, 667], [184, 139], [840, 118], [577, 469]]

        expected = 1859

        result = self.twoCitySchedCost(costs)

        print(result)

        return expected == result

    def twoCitySchedCost(self, costs: List[List[int]]) -> int:
        n = len(costs) // 2
        costs.sort(key=lambda x: x[0] - x[1])
        result = 0
        for i in range(n):
            result += costs[i][0] + costs[n + i][1]
        return result