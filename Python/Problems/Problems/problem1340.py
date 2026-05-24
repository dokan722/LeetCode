import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1340(Problem):
    def test(self) -> bool:
        arr = [6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12]
        d = 2

        expected = 4

        result = self.maxJumps(arr, d)

        print(result)

        return result == expected

    def maxJumps(self, arr: List[int], d: int) -> int:
        n = len(arr)
        dp = [0] * n
        result = 0
        for i in range(n):
            self.dfs(arr, d, i, n, dp)
            result = max(result, dp[i])

        return result

    def dfs(self, arr: List[int], d: int, id: int, n: int , dp: List[int]) -> None:
        if dp[id] != 0:
            return
        dp[id] = 1
        i = id - 1
        while i >= 0 and id - i <= d and arr[i] < arr[id]:
            self.dfs(arr, d, i, n, dp)
            dp[id] = max(dp[id], dp[i] + 1)
            i -= 1
        i = id + 1
        while i < n and i - id <= d and arr[i] < arr[id]:
            self.dfs(arr, d, i, n, dp)
            dp[id] = max(dp[id], dp[i] + 1)
            i += 1