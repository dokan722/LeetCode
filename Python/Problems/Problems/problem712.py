import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem712(Problem):
    def test(self) -> bool:
        s1 = "delete"
        s2 = "leet"

        expected = 403

        result = self.minimumDeleteSum(s1, s2)

        print(result)

        return result == expected

    def minimumDeleteSum(self, s1: str, s2: str) -> int:
        n = len(s1)
        m = len(s2)
        dp = []
        for i in range(n + 1):
            dp.append([0] * (m + 1))
        for i in range(1, n + 1):
            dp[i][0] = dp[i - 1][0] + ord(s1[i - 1])
        for i in range(1, m + 1):
            dp[0][i] = dp[0][i - 1] + ord(s2[i - 1])

        for i in range(n):
            for j in range(m):
                addBoth = dp[i][j] + (0 if s1[i] == s2[j] else ord(s1[i]) + ord(s2[j]))
                addFirst = dp[i][j + 1] + ord(s1[i])
                addSecond = dp[i + 1][j] + ord(s2[j])
                dp[i + 1][j + 1] = min(addBoth, min(addFirst, addSecond))

        return dp[n][m]