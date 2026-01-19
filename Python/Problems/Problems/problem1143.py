import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1143(Problem):
    def test(self) -> bool:
        text1 = "abcde"
        text2 = "ace"

        expected = 3

        result = self.longestCommonSubsequence(text1, text2)

        print(result)

        return result == expected

    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        n = len(text1)
        m = len(text2)
        dp = []
        for _ in range(n + 1):
            dp.append([0] * (m + 1))
        for i in range(1, n + 1):
            for j in range(1, m + 1):
                dp[i][j] = max(dp[i - 1][j - 1] + (1 if text1[i - 1] == text2[j - 1] else 0), max(dp[i - 1][j], dp[i][j - 1]))

        return dp[n][m]