import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1043(Problem):
    def test(self) -> bool:
        arr = [1, 15, 7, 9, 2, 5, 10]
        k = 3

        expected = 84

        result = self.maxSumAfterPartitioning(arr, k)

        print(result)

        return result == expected

    def maxSumAfterPartitioning(self, arr: List[int], k: int) -> int:
        n = len(arr)
        dp = [0] * n
        m = 0
        for i in range(k):
            m = max(m, arr[i])
            dp[i] = (i + 1) * m
        for i in range(k, n):
            m = arr[i]
            curr = arr[i]
            best = curr + dp[i - 1]
            for j in range(1, k):
                if m < arr[i - j]:
                    curr += j * (arr[i - j] - m)
                    m = arr[i - j]

                curr += m
                best = max(best, dp[i - j - 1] + curr)
            dp[i] = best

        return dp[n - 1]