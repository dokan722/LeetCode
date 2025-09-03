import sys
from typing import List

from .problem import Problem


class Problem877(Problem):
    def test(self) -> bool:
        piles = [7, 8, 8, 10]

        expected = True

        result = self.stoneGame(piles)

        return expected == result

    def stoneGame(self, piles: List[int]) -> bool:
        n = len(piles)
        dp = []
        for i in range(n):
            dp.append([-sys.maxsize] * n)
        return self.stoneGameRec(piles, dp, 0, n - 1, True) > 0

    def stoneGameRec(self, piles: List[int], dp: List[List[int]], i: int, j: int, aliceTurn: bool) -> int:
        if i == j:
            return -piles[i]
        if dp[i][j] != -sys.maxsize:
            return dp[i][j]
        fromLeft = self.stoneGameRec(piles, dp, i + 1, j, not aliceTurn) + (piles[i] if aliceTurn else -piles[i])
        fromRight = self.stoneGameRec(piles, dp, i, j - 1, not aliceTurn) + (piles[j] if aliceTurn else -piles[j])
        dp[i][j] = max(fromLeft, fromRight) if aliceTurn else min(fromLeft, fromRight)
        return dp[i][j]