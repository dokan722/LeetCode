import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3840(Problem):
    def test(self) -> bool:
        nums = [1, 4, 3, 5]
        colors = [1, 1, 2, 2]

        expected = 9

        result = self.rob(nums, colors)

        print(result)

        return expected == result

    def rob(self, nums: List[int], colors: List[int]) -> int:
        n = len(nums)
        result = 0
        prev = -1
        dp = [0, 0]
        cur = 0
        for i in range(n):
            if prev != colors[i]:
                result += cur
                dp[0] = 0
                dp[1] = 0
                prev = colors[i]
            cur = max(nums[i] + dp[0], dp[1])
            dp[0] = dp[1]
            dp[1] = cur
        result += cur

        return result