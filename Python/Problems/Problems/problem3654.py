import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3654(Problem):
    def test(self) -> bool:
        nums = [1, 1, 1]
        k = 2

        expected = 1

        result = self.minArraySum(nums, k)

        print(result)

        return result == expected

    def minArraySum(self, nums: List[int], k: int) -> int:
        n = len(nums)
        dp = [sys.maxsize] * k
        s = 0
        dp[0] = 0
        for i in range(n):
            s += nums[i]
            s = min(s, dp[s % k])
            dp[s % k] = s

        return s