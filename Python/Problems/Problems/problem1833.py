from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem1833(Problem):
    def test(self) -> bool:
        costs = [1, 3, 2, 4, 1]
        coins = 7

        expected = 4

        result = self.maxIceCream(costs, coins)

        print(result)

        return expected == result

    def maxIceCream(self, costs: List[int], coins: int) -> int:
        costs.sort()

        i = 0
        while i < len(costs) and costs[i] <= coins:
            coins -= costs[i]
            i += 1

        return i