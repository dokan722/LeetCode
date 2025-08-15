from typing import List, Dict

from .problem import Problem


class Problem1561(Problem):
    def test(self) -> bool:
        piles = [2, 4, 1, 2, 7, 8]

        expected = 9

        result = self.maxCoins(piles)

        print(result)

        return expected == result

    def maxCoins(self, piles: List[int]) -> int:
        n = len(piles)
        piles.sort()

        sum = 0

        for i in range(n // 3):
            sum += piles[n - 2 - 2 * i]

        return sum