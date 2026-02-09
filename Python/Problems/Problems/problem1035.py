import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1035(Problem):
    def test(self) -> bool:
        nums1 = [2, 5, 1, 2, 5]
        nums2 = [10, 5, 2, 1, 5, 2]

        expected = 3

        result = self.maxUncrossedLines(nums1, nums2)

        print(result)

        return expected == result

    def maxUncrossedLines(self, nums1: List[int], nums2: List[int]) -> int:
        n = len(nums1)
        m = len(nums2)
        dp = []
        for i in range(n + 1):
            dp.append([0] * (m + 1))
        for i in range(n):
            for j in range(m):
                takeBoth = dp[i][j] + (1 if nums1[i] == nums2[j] else 0)
                takeFirst = dp[i][j + 1]
                takeSecond = dp[i + 1][j]
                dp[i + 1][j + 1] = max(takeBoth, max(takeFirst, takeSecond))

        return dp[n][m]