import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1458(Problem):
    def test(self) -> bool:
        nums1 = [2, 1, -2, 5]
        nums2 = [3, 0, -6]

        expected = 18

        result = self.maxDotProduct(nums1, nums2)

        print(result)

        return result == expected

    def maxDotProduct(self, nums1: List[int], nums2: List[int]) -> int:
        n = len(nums1)
        m = len(nums2)
        dp = []
        for i in range(n):
            dp.append([0] * m)
        dp[0][0] = nums1[0] * nums2[0]
        result = dp[0][0]
        for i in range(n):
            for j in range(m):
                takeBoth = nums1[i] * nums2[j] + (dp[i - 1][j - 1] if i > 0 and  j > 0 else 0)
                takeBothAndSkip = nums1[i] * nums2[j]
                skipFirst = dp[i - 1][j] if i > 0 else -sys.maxsize
                skipSecond = dp[i][j - 1] if j > 0 else -sys.maxsize
                dp[i][j] = max(takeBoth, max(takeBothAndSkip, max(skipFirst, skipSecond)))

        return dp[n - 1][m - 1]