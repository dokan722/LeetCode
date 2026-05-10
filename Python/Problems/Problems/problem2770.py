import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2770(Problem):
    def test(self) -> bool:
        nums = [1, 3, 6, 4, 1, 2]
        target = 2

        expected = 3

        result = self.maximumJumps(nums, target)

        print(result)

        return result == expected

    def maximumJumps(self, nums: List[int], target: int) -> int:
        n = len(nums)
        dp = [0] * n
        for i in range(n - 2, -1, -1):
            mx = -1

            for j in range(i + 1, n):
                if abs(nums[i] - nums[j]) <= target and dp[j] != -1:
                    mx = max(mx, dp[j] + 1)
            dp[i] = mx

        return dp[0]