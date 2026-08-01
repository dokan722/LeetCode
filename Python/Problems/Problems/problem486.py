import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem486(Problem):
    def test(self) -> bool:
        nums = [1, 5, 2]

        expected = False

        result = self.predictTheWinner(nums)

        return result == expected

    def predictTheWinner(self, nums: List[int]) -> bool:
        n = len(nums)
        first = n % 2
        dp = [-nums[i] if first == 0 else nums[i] for i in range(n)]
        for i in range(n - 1, 0, -1):
            sh = n - i
            for j in range(i):
                dp[j] = max(dp[j] + nums[j + sh], dp[j + 1] + nums[j]) if i % 2 == 1 else min(dp[j] - nums[j + sh], dp[j + 1] - nums[j])

        return dp[0] >= 0