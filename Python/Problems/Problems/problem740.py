import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem740(Problem):
    def test(self) -> bool:
        nums = [3, 4, 2]

        expected = 6

        result = self.deleteAndEarn(nums)

        print(result)

        return expected == result

    def deleteAndEarn(self, nums: List[int]) -> int:
        counts = [0] * 10001
        mx = 0
        for num in nums:
            counts[num] += 1
            mx = max(mx, num)
        dp = [0] * (mx + 1)
        dp[0] = 0
        dp[1] = counts[1]
        for i in range(2, mx + 1):
            dp[i] = max(dp[i - 1], counts[i] * i + dp[i - 2])

        return dp[mx]