import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem960(Problem):
    def test(self) -> bool:
        strs = ["babca", "bbazb"]

        expected = 3

        result = self.minDeletionSize(strs)

        print(result)

        return result == expected

    def minDeletionSize(self, strs: List[str]) -> int:
        n = len(strs)
        m = len(strs[0])
        dp = [1] * m
        for i in range(m):
            for j in range(i):
                sorted = True
                for k in range(n):
                    if strs[k][i] < strs[k][j]:
                        sorted = False
                        break
                if sorted:
                    dp[i] = max(dp[i], dp[j] + 1)

        result = 0
        for i in range(m):
            result = max(result, dp[i])

        return m - result