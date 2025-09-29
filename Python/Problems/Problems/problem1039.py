import sys
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1039(Problem):
    def test(self) -> bool:
        values = [1, 3, 1, 4, 1, 5]

        expected = 13

        result = self.minScoreTriangulation(values)

        print(result)

        return result == expected

    def minScoreTriangulation(self, values: List[int]) -> int:
        n = len(values)
        dp = []
        for i in range(n):
            dp.append([-1] * n)
        return self.minScoreRec(0, n - 1, values, dp)

    def minScoreRec(self, left: int, right: int, values: List[int],  dp: List[List[int]]) -> int:
        if left > right - 2:
            return 0
        if dp[left][right] == -1:
            minScore = sys.maxsize
            for i in range(left + 1, right):
                minScore = min(minScore, self.minScoreRec(left, i, values, dp)
                               + values[left] * values[right] * values[i] + self.minScoreRec(i, right, values, dp));
            dp[left][right] = minScore

        return dp[left][right]