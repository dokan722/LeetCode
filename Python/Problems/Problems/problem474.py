import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem474(Problem):
    def test(self) -> bool:
        strs = ["10", "0001", "111001", "1", "0"]
        m = 5
        n = 3

        expected = 4

        result = self.findMaxForm(strs, m, n)

        print(result)

        return result == expected

    def findMaxForm(self, strs: List[str], m: int, n: int) -> int:
        dp = []
        for _ in range(m + 1):
            dp.append([0] * (n + 1))

        for str in strs:
            zeros = 0
            for c in str:
                if c == '0':
                    zeros += 1
            ones = len(str)- zeros
            for i in range(m, zeros - 1, -1):
                for j in range(n, ones - 1, -1):
                    dp[i][j] = max(dp[i][j], dp[i - zeros][j - ones] + 1)

        result = 0
        for i in range(1, m + 1):
            for j in range(1, n + 1):
                result = max(result, dp[i][j])

        return result